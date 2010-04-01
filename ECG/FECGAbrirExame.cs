using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECG.Graphics;

namespace ECG
{
    public partial class FECGAbrirExame : Form
    {
        Bitmap imagem;

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
                MessageBox.Show("Por favor, escolha um arquivo válido");

                return;
            }
            
            imagem = new Bitmap(file);
            picBox.Width = imagem.Width;
            picBox.Height = imagem.Height;
            picBox.Image = imagem;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            ECGOndaBitmap ecgonda = new ECGOndaBitmap(imagem);

            OndaHelper helper = new OndaHelper();

            double[,] ondaArray = ecgonda.GerarArray();

            int[] picosQRS = helper.PicosQRS(ecgonda.GerarArray(), imagem.Width, imagem.Height);

            double[] vetor = ecgonda.GerarVetor();

            ondaChart.Series[0].Points.Clear();

            foreach (int i in vetor)
            {
                Console.Write(i + "; ");
                ondaChart.Series[0].Points.Add(i);
            }

            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    Console.Write(ondaArray[x, y]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(i + " -> " + vetor[i]); 
            }

            for (int i = 0; i < picosQRS.Length; i++)
            {
                Console.WriteLine("QRS em " + i + " -> " + picosQRS[i]);
            }

            int[] extremos = helper.ExtremosQRS(vetor, picosQRS[0]);

            Console.WriteLine("Início de QRS em {0} e fim em {1}", extremos[0], extremos[1]);
        }
    }
}
