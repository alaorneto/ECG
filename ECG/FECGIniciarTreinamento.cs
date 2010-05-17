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
            comboBoxOnda.SelectedItem = "Complexo QRS";
        }

        private void buttonTreinar_Click(object sender, EventArgs e)
        {
            if (comboBoxOnda.SelectedItem == "Complexo QRS")
            {
                TreinarQRS();
                /*Thread worker = new Thread(new ThreadStart(TreinarQRS));
                worker.Start();*/
            }
            if (comboBoxOnda.SelectedItem == "Onda T")
            {
                TreinarT();
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
                    treinamentoChart.Series[0].Points.Add(coeficiente);
                    Console.WriteLine("Coeficiente: {0}", coeficiente);
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
        }

        private void TreinarT()
        {
        }

        private void AtualizarChart()
        {


        }
    }
}
