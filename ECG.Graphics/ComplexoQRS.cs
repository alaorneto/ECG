using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Graphics
{
    public class ComplexoQRS
    {
        OndaHelper helper;
        double[][] qrs;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
        public ComplexoQRS(Bitmap imagem)
        {
            helper = new OndaHelper(imagem);

            int[] picosQRS = helper.PicosQRS();

            qrs = new double[picosQRS.Length][];

            for(int i = 0; i < picosQRS.Length; i++)
            {
                int inicio, fim;
                int[] extremos = helper.ExtremosQRS(picosQRS[i]);
                inicio = extremos[0];
                fim = extremos[1];
                qrs[i] = helper.SubVetor(inicio, fim);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double[] this[int index]
        {
            get { return qrs[index]; }
        }
    }
}
