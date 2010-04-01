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
    public class ECGOndaBitmap
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem">O objeto Bitmap com a imagem da onda a ser trabalhada</param>
        public ECGOndaBitmap(Bitmap imagem)
        {
            this.Bitmap = imagem;
        }

        /// <summary>
        /// Provê acesso ao objeto Bitmap que está sendo trabalhado nesta instância de ECGOndaBitmap
        /// </summary>
        public Bitmap Bitmap
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ConverterParaBinario()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this.Bitmap = helper.Binary(this.Bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ConverterParaEscalaDeCinza()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this.Bitmap = helper.GrayScale(this.Bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double[,] GerarArray()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarArray(this.Bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna um vetor de uma dimensão representando a oscilação da onda no eixo X</returns>
        public double[] GerarVetor()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarVetor(this.Bitmap);
        }
    }
}
