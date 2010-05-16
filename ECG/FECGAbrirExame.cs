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

            // Determinar a frequência cardíaca
            int[] picos = onda.PicosQRS;
            double freq = 1500 / ((picos[1] - picos[0]) / 8);

            labelFreqResult.Text = freq.ToString("000") + " bpm";

            // Calcular o resultado do padrão da onda
            RedeAtivacao qrs = ECGConfig.RedeQRS();

            double[] saidaqrs = qrs.Calcular(onda.ComplexosQRS[0].Vetor);

            Console.WriteLine("Saída do 1º Complexo QRS: {0}", saidaqrs);


        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            try { 
                onda.Salvar();
                MessageBox.Show("Onda salva com sucesso!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }

            FECGSalvarExame fsalvar = new FECGSalvarExame();
            
            fsalvar.ShowDialog();
        }
    }
}
