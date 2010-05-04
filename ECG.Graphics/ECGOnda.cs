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
        public OndaT OndaT;
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

            for (int i = 0; i < ComplexoQRS.Length; i++)
                Console.WriteLine("Pico {0} em {1}", i, ComplexoQRS.picosQRS[i]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double this[int index]
        {
            get { return vetor[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Lenght
        {
            get { return vetor.Length; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Bitmap Bitmap
        {
            get { return this.bitmap; }
        }


    }
}
