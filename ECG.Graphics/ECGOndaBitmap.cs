using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Graphics
{
    /// <summary>
    /// 
    /// </summary>
    public class ECGOndaBitmap
    {
        private Bitmap _bitmap;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
        public ECGOndaBitmap(Bitmap imagem)
        {
            this._bitmap = imagem;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ConverterParaBinario()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this._bitmap = helper.Binary(this._bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ConverterParaEscalaDeCinza()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this._bitmap = helper.GrayScale(this._bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float[,] GerarArray()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarArray(this._bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float[] GerarVetor()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarVetor(this._bitmap);
        }
    }
}
