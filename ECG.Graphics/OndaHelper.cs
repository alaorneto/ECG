using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Graphics
{
    /// <summary>
    /// Classe helper com métodos de ajuda para extração de informações sobre ondas pertencentes a um
    /// eletrocardiograma, como seus picos e seus extremos
    /// </summary>
    public class OndaHelper
    {
        protected const int MAX_QRS = 999;
        protected const int MAX_T = 999;
        protected const int MAX_P = 999;

        /// <summary>
        /// Encontra os picos das ondas R do complexo QRS em uma onda dada
        /// </summary>
        /// <param name="onda">Vetor representativo da onda na qual se deseja encontrar os picos do complexo QRS</param>
        /// <param name="xSize">O tamanho X (largura) da onda informada</param>
        /// <param name="ySize">O tamanho Y (altura) da onda informada</param>
        /// <returns></returns>
        public int[] PicosQRS(double[,] onda, int xSize, int ySize)
        {
            int count_picos = 0;
            int[] picos = new int[MAX_QRS];
            bool finish = false;

            for (int y = 0; y < ySize; y++ )
            {
                int count = 0;
                int index_soma = 0;
                bool found = false;

                for (int x = 0; x < xSize; x++)
                {
                    if (onda[x, y] == 1)
                    {
                        index_soma += x;
                        count++;
                        found = true;
                        finish = true;
                    }
                    if (onda[x, y] == 0)
                    {
                        if (found == true)
                        {
                            picos[count_picos++] += index_soma / count;

                            index_soma = 0;
                            count = 0;
                            found = false;
                        }
                    }
                }

                if (finish)
                    break;
            }

            int[] finalpicos = new int[count_picos];

            for (int i = 0; i < count_picos; i++)
                finalpicos[i] = picos[i];

            return finalpicos;
        }

        /// <summary>
        /// Encontra os extremos de um complexo QRS com base na posição do pico da onda R
        /// </summary>
        /// <param name="onda">Vetor representativo do eletrocardiograma onde foi localizado o pico para detecção de seus extremos</param>
        /// <param name="picoQRS">Posição onde se encontra o pico do qual se deseja encontrar os pontos extremos</param>
        /// <returns></returns>
        public int[] ExtremosQRS(double[] onda, int picoQRS)
        {
            int[] extremos = new int[2];

            bool walking = true;
            int index = picoQRS;

            // Percorre o trecho ANTERIOR ao pico da onda R até encontrar o VALE (onda Q)
            while (walking)
            {
                if ((onda[index - 1] >= onda[index]) &&
                    (onda[index - 2] >= onda[index]) &&
                    (onda[index - 3] >= onda[index]) &&
                    (onda[index - 4] >= onda[index]) &&
                    (onda[index - 5] >= onda[index]))
                {
                    walking = false;
                }

                index--;
            }

            walking = true;

            while (walking)
            {
                if ((onda[index - 1] < onda[index]) ||
                    (onda[index - 2] < onda[index]) ||
                    (onda[index - 3] < onda[index]))
                {
                    walking = false;
                }

                index--;
            }

            extremos[0] = index;
            
            // Resetando as variáveis de controle
            index = picoQRS;
            walking = true;

            // Percorre o trecho POSTERIOR ao pico da onda R até encontrar o VALE (onda S)
            while (walking)
            {
                if ((onda[index + 1] >= onda[index]) &&
                    (onda[index + 2] >= onda[index]) &&
                    (onda[index + 3] >= onda[index]) &&
                    (onda[index + 4] >= onda[index]) &&
                    (onda[index + 5] >= onda[index]))
                {
                    walking = false;
                }

                index++;
            }

            walking = true;

            while (walking)
            {
                if ((onda[index + 1] < onda[index]) ||
                    (onda[index + 2] < onda[index]) ||
                    (onda[index + 3] < onda[index]))
                {
                    walking = false;
                }

                index--;
            }

            extremos[1] = index;

            return extremos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onda"></param>
        /// <param name="xSize"></param>
        /// <param name="ySize"></param>
        /// <returns></returns>
        public int[] PicosT(double[] onda, int xSize, int ySize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onda"></param>
        /// <param name="picoT"></param>
        /// <returns></returns>
        public int[] ExtremosT(float[] onda, int picoT)
        {
            throw new NotImplementedException();
        }
    }
}
