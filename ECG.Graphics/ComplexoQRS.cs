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
        public int[] picosQRS;

        /// <summary>
        /// Cria uma nova instância de um objeto do tipo ComplexoQRS, recebendo uma imagem Bitmap como parâmetro,
        /// para fornecer informações sobre os complexos QRS que existem dentro da onda informada
        /// </summary>
        /// <param name="imagem">Bitmap representativo da onda a ser analisada</param>
        public ComplexoQRS(Bitmap imagem)
        {
            // Cria o helper que ajudará na construção do objeto
            helper = new OndaHelper(imagem);

            // Descobre os picos dos complexos QRS na onda informada
            picosQRS = helper.PicosQRS();
            qrs = new double[picosQRS.Length][];

            // Para cada pico descoberto devemos localizar os complexos QRS
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

        public int Length
        {
            get { return picosQRS.Length; }
        }
    }
}
