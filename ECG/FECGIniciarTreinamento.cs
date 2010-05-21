using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECG.Framework;
using ECG.Framework.IA;
using System.Threading;

namespace ECG
{
    public partial class FECGIniciarTreinamento : Form
    {
        public delegate void AtualizarChartDelegate(double taxaErro);
        public AtualizarChartDelegate chartDelegate;

        public FECGIniciarTreinamento()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FECGIniciarTreinamento_Load(object sender, EventArgs e)
        {
            chartDelegate = new AtualizarChartDelegate(AtualizarChart);

            comboBoxOnda.SelectedItem = "Complexo QRS";
        }

        private void buttonTreinar_Click(object sender, EventArgs e)
        {
            if (comboBoxOnda.SelectedItem == "Complexo QRS")
            {
                Thread worker = new Thread(new ThreadStart(TreinarQRS));
                worker.Start();
            }
            if (comboBoxOnda.SelectedItem == "Onda T")
            {
                Thread worker = new Thread(new ThreadStart(TreinarT));
                worker.Start();
            }
        }

        private void TreinarQRS()
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<ComplexoQRS> qrslist = new List<ComplexoQRS>();
            double erro = 1;
            double taxaerro = double.Parse(textBoxTaxaErro.Text);
            int count = 0; 

            var query = from q in entities.QRS
                        select q;

            foreach (QRS qrs in query)
            {
                qrslist.Add(new ComplexoQRS(qrs));
            }

            AprendizadoBackPropagation abp = new AprendizadoBackPropagation(ECGConfig.RedeQRS());
            
            double coeficiente = taxaerro;

            while (coeficiente >= taxaerro)
            {
                foreach (ComplexoQRS qrs in qrslist)
                {
                    erro += abp.Executar(qrs.Vetor, qrs.Diagnostico);
                    count++;

                    coeficiente = erro / count;

                    treinamentoChart.Invoke(this.chartDelegate, coeficiente);
                    
                    //Console.WriteLine("Taxa de erro: {0}", coeficiente);
                }
            }

            RedeAtivacao rede = abp.Rede;

            foreach (ComplexoQRS qrs in qrslist)
            {
                double[] saida = Utils.AproximarDiagnostico(rede.Calcular(qrs.Vetor));

                Console.WriteLine("Saída da rede treinada: {0}-{1}-{2}-{3}", saida[0], saida[1], saida[2], saida[3]);
            }

            RedeServices services = new RedeServices();

            services.Salvar(abp.Rede, RedeServices.Tipo.Ativacao, "QRS");

            MessageBox.Show("Treinamento concluído com sucesso!\nRede salva no banco de dados");
        }

        private void TreinarT()
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<OndaT> tlist = new List<OndaT>();
            double erro = 1;
            double taxaerro = double.Parse(textBoxTaxaErro.Text);
            int count = 0;

            var query = from q in entities.T
                        select q;

            foreach (T t in query)
            {
                tlist.Add(new OndaT(t));
            }

            AprendizadoBackPropagation abp = new AprendizadoBackPropagation(ECGConfig.RedeT());

            double coeficiente = taxaerro;

            while (coeficiente >= taxaerro)
            {
                foreach (OndaT t in tlist)
                {
                    erro += abp.Executar(t.Vetor, t.Diagnostico);
                    count++;

                    coeficiente = erro / count;

                    treinamentoChart.Invoke(this.chartDelegate, coeficiente);

                    //Console.WriteLine("Taxa de erro: {0}", coeficiente);
                }
            }

            RedeAtivacao rede = abp.Rede;

            foreach (OndaT t in tlist)
            {
                double[] saida = Utils.AproximarDiagnostico(rede.Calcular(t.Vetor));

                Console.WriteLine("Saída da rede treinada: {0}-{1}-{2}-{3}", saida[0], saida[1], saida[2], saida[3]);
            }

            RedeServices services = new RedeServices();

            services.Salvar(abp.Rede, RedeServices.Tipo.Ativacao, "T");

            MessageBox.Show("Treinamento concluído com sucesso!\nRede salva no banco de dados");
        }

        private void AtualizarChart(double taxaErro)
        {
            treinamentoChart.Series[0].Points.Add(taxaErro);
        }
    }
}
