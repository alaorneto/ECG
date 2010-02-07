using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Graphics
{
    public class OndaHelper
    {
        protected const int MAX_QRS = 999;
        protected const int MAX_T = 999;
        protected const int MAX_P = 999;

        public int[] PicosQRS(float[,] onda, int xSize, int ySize)
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

        public int[] ExtremosQRS(float[] onda, int picoQRS)
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
    }
}
