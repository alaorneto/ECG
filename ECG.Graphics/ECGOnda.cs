using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Graphics
{
    /// <summary>
    /// Esta classe encapsula um Bitmap representando a derivação do exame a ser analisada e provê funcções
    /// úteis para a transformação dessa imagem para outras formas de representação
    /// </summary>
    public class ECGOnda
    {
        public ComplexoQRS ComplexoQRS;
        private OndaHelper helper;
        private Bitmap bitmap;
        private double[] vetor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem">O objeto Bitmap com a imagem da onda a ser trabalhada</param>
        public ECGOnda(Bitmap imagem)
        {
            bitmap = imagem;

            helper = new OndaHelper(imagem);

            vetor = helper.GerarVetor();

            ComplexoQRS = new ComplexoQRS(imagem);
        }

        public double this[int index]
        {
            get { return vetor[index]; }
        }

        public int Lenght
        {
            get { return vetor.Length; }
        }

        public Bitmap Bitmap
        {
            get { return this.bitmap; }
        }
    }
}
