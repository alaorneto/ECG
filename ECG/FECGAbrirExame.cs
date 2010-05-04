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
            ECGOnda onda = new ECGOnda(imagem);

            ondaChart.Series[0].Points.Clear();

            for (int i = 0; i < onda.Lenght; i++)
            {
                Console.Write(onda[i] + "; ");
                ondaChart.Series[0].Points.Add(onda[i]);
            }


        }
    }
}
