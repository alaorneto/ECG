using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Graphics
{
    /// <summary>
    /// Classe helper com métodos de ajuda para extração de informações sobre ondas pertencentes a um
    /// eletrocardiograma, como seus picos e seus extremos
    /// </summary>
    public class OndaHelper
    {
        private Bitmap bitmap;
        protected const int MAX_QRS = 999;
        protected const int MAX_T = 999;
        protected const int MAX_P = 999;

        public OndaHelper(Bitmap imagem)
        {
            this.bitmap = imagem;
        }

        /// <summary>
        /// Provê acesso ao objeto Bitmap que está sendo trabalhado nesta instância de ECGOndaBitmap
        /// </summary>
        public Bitmap Bitmap
        {
            get { return this.bitmap; }
            set { this.bitmap = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ConverterParaBinario()
        {
            ConversaoHelper helper = new ConversaoHelper();

            this.Bitmap = helper.Binary(this.Bitmap);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ConverterParaEscalaDeCinza()
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

        /// <summary>
        /// Encontra os picos das ondas R do complexo QRS em uma onda dada
        /// </summary>
        /// <param name="onda">Vetor representativo da onda na qual se deseja encontrar os picos do complexo QRS</param>
        /// <param name="xSize">O tamanho X (largura) da onda informada</param>
        /// <param name="ySize">O tamanho Y (altura) da onda informada</param>
        /// <returns></returns>
        public int[] PicosQRS()
        {
            double[,] onda = GerarArray();
            int xSize = bitmap.Width;
            int ySize = bitmap.Height;
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
        public int[] ExtremosQRS(int picoQRS)
        {
            double[] onda = GerarVetor();
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

            // Percorre o trecho ANTERIOR ao vale da onda Q até achar o INÍCIO do complexo QRS
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

            // Percorre o trecho POSTERIOR ao vale da onda S até achar o FINAL do complexo QRS
            walking = true;

            while (walking)
            {
                if ((onda[index + 1] < onda[index]) ||
                    (onda[index + 2] < onda[index]) ||
                    (onda[index + 3] < onda[index]))
                {
                    walking = false;
                }

                index++;
            }

            extremos[1] = index;

            int lenght = (extremos[1] - extremos[0]) + 1;
            double[] qrs = new double[lenght];

            for(int i = 0; i < lenght; i++)
            {
                qrs[i] = onda[i + extremos[0]];
            }

            foreach (double d in qrs)
                Console.Write(d + "; ");

            return extremos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fim"></param>
        /// <returns></returns>
        public double[] SubVetor(int inicio, int fim)
        {
            double[] vetor = GerarVetor();
            int lenght = (fim - inicio) + 1;
            double[] subvetor = new double[lenght];

            for(int i = 0; i < lenght; i++)
            {
                subvetor[i] = vetor[i + inicio];
            }

            return subvetor;
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
