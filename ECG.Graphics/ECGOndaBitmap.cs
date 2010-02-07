using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Graphics
{
    public class ECGOndaBitmap
    {
        private Bitmap _bitmap;

        public ECGOndaBitmap(Bitmap imagem)
        {
            this._bitmap = imagem;
        }

        public void ConverterParaBinario()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this._bitmap = helper.Binary(this._bitmap);
        }

        public void ConverterParaEscalaDeCinza()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this._bitmap = helper.GrayScale(this._bitmap);
        }

        public float[,] GerarArray()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarArray(this._bitmap);
        }

        public float[] GerarVetor()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            return helper.GerarVetor(this._bitmap);
        }
    }
}
