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
using ECG.Framework.Graphics;

namespace ECG
{
    public partial class FECGAbrirExame : Form
    {
        Bitmap imagem;
        Onda onda;
        double[] patQRS;
        double[] patT;

        public FECGAbrirExame()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Ecolher imagem";
            string file = "";
            dialog.Filter = "Bitmaps/Gif/jpeg (*.bmp;*.gif)|*.gif;*.bmp;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
            }
            else
            {
                MessageBox.Show("Por favor, escolha um arquivo válido.");

                return;
            }
            
            imagem = new Bitmap(file);
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            onda = new Onda(imagem);

            ondaChart.Series[0].Points.Clear();

            for (int i = 0; i < onda.Length; i++)
            {
                ondaChart.Series[0].Points.Add(onda.Vetor[i]);
            }

            Console.WriteLine(" -->> {0} complexos QRS encontrado(s)", onda.ComplexosQRS.Length);
            Console.WriteLine(" -->> {0} ondas T encontrada(s)", onda.OndasT.Length);

            // Determinar a frequência cardíaca
            int[] picos = onda.PicosQRS;
            double freq = 1500 / ((picos[1] - picos[0]) / 8);

            labelFreqResult.Text = freq.ToString("000") + " bpm";

            Patologias patologias = new Patologias();

            // Calcular o resultado do padrão da onda

            // Resultado do Complexo QRS
            RedeAtivacao qrs = ECGConfig.RedeQRS();

            patQRS = Utils.AproximarDiagnostico(qrs.Calcular(onda.ComplexosQRS[0].Vetor));

            Console.WriteLine("Saída do 1º Complexo QRS: {0}-{1}-{2}-{3}", patQRS[0], patQRS[1], patQRS[2], patQRS[3]);

            labelDiagQRSResult.Text = patologias.EncontrarNomePorSaida(patQRS, "QRS");

            // Resultado da Onda T
            RedeAtivacao t = ECGConfig.RedeT();

            patT = Utils.AproximarDiagnostico(t.Calcular(onda.OndasT[0].Vetor));

            Console.WriteLine("Saída da 1ª Onda T: {0}-{1}-{2}-{3}", patT[0], patT[1], patT[2], patT[3]);

            labelDiagTResult.Text = patologias.EncontrarNomePorSaida(patT, "T");
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            FECGSalvarExame fsalvar = new FECGSalvarExame(onda, patQRS, patT);
            
            fsalvar.ShowDialog();
        }

        private void buttonDetalhar_Click(object sender, EventArgs e)
        {
            FDetalhaOndas dialog = new FDetalhaOndas(onda.ComplexosQRS[0].Vetor, onda.ComplexosQRS[1].Vetor, onda.OndasT[0].Vetor, onda.OndasT[1].Vetor);

            dialog.ShowDialog();
        }
    }
}
