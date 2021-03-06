﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ECG.Framework.Graphics;

namespace ECG.Framework
{
    /// <summary>
    /// Classe helper com métodos de ajuda para extração de informações sobre ondas pertencentes a um
    /// eletrocardiograma, como seus picos e seus extremos
    /// </summary>
    public class OndaHelper
    {
        private Bitmap bitmap;
        private double[] vetor;
        protected const int MAX_QRS = 999;
        protected const int MAX_T = 999;
        protected const int MAX_P = 999;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
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

            vetor = helper.GerarVetor(this.Bitmap);

            AjustarZero();

            return vetor;
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
            int[] picos = new int[MAX_QRS];
            int count_picos = 0;
            int length = vetor.Length;
            int index_max = 0;
            double top = 0;
            double max = 0;

            // Encontra o primeiro pico QRS
            for (int i = 0; i < length; i++)
            {
                if (vetor[i] > max)
                {
                    max = vetor[i];
                    top = max;
                    index_max = i;
                }
            }

            picos[count_picos++] = index_max;

            int[] extremos = ExtremosQRS(picos[0]);

            // Procura outro pico QRS à esqueda do primeiro pico
            index_max = 0;
            max = 0;

            for (int i = 0; i < extremos[0]; i++)
            {
                if ((vetor[i] > top * .8) && (vetor[i] > max))
                {
                    max = vetor[i];
                    index_max = i;
                }
            }

            if (index_max != 0)
                picos[count_picos++] = index_max;

            // Procura outro pico QRS à direita do primeiro pico
            index_max = 0;
            max = 0;

            for (int i = extremos[1]; i < length; i++)
            {
                if ((vetor[i] > top * .8) && (vetor[i] > max))
                {
                    max = vetor[i];
                    index_max = i;
                }
            }

            if (index_max != 0)
                picos[count_picos++] = index_max;

            int[] finalpicos = new int[count_picos];

            if ((picos[0] > picos[1]))
            {
                finalpicos[0] = picos[1];
                finalpicos[1] = picos[0];
            }
            else
            {
                finalpicos[0] = picos[0];
                finalpicos[1] = picos[1];
            }

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
                if ((onda[index - 1] <= onda[index]) &&
                    (onda[index - 2] <= onda[index]) &&
                    (onda[index - 3] <= onda[index]))
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
                if ((onda[index + 1] <= onda[index]) &&
                    (onda[index + 2] <= onda[index]) &&
                    (onda[index + 3] <= onda[index]))
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

            return extremos;
        }

        public ComplexoQRS[] ComplexosQRS()
        {
            int[] picos = PicosQRS();
            ComplexoQRS[] complexosQRS = new ComplexoQRS[picos.Length];

            for(int i = 0; i < picos.Length; i++)
            {
                int[] extremos = ExtremosQRS(picos[i]);
                ComplexoQRS qrs = new ComplexoQRS(SubVetor(extremos[0], extremos[1]));
                complexosQRS[i] = qrs;
            }

            return complexosQRS;
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
                if ((i + inicio) >= vetor.Length)
                {
                    subvetor[i] = subvetor[i - 1];
                }
                else
                {
                    subvetor[i] = vetor[i + inicio];
                }
            }

            return subvetor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onda"></param>
        /// <param name="picoT"></param>
        /// <returns></returns>
        public int[] ExtremosT(double[] onda, int picoQRS)
        {
            int[] extremosQRS = ExtremosQRS(picoQRS);
            int[] extremosT = new int[2];
            int length = onda.Length;
            int index = extremosQRS[1];
            int inicio = index;
            int fim = onda.Length;
            double media = 0.0;
            double proxcount = 0.0;
            int count = 0;
            int flag = 0;

            Console.WriteLine("extremo qrs {0}", extremosQRS[1]);

            while (onda[index] < 0)
            {
                index++;
            }

            inicio = index;

            // Calcular a média dos pontos após o complexo QRS para tentar detectar
            // a presença de uma onda T
            while (count < 70)
            {
                if ((index + 1) > length)
                    break;

                proxcount += onda[index++];
                count++;
            }

            media = proxcount / count;

            Console.WriteLine(media);

            // Checar se existe onda T positiva ou negativa, ou ainda se a onda
            // T é inexistente, comparando-se a média dos pontos após o fim do complexo QRS
            if ((media > -0.05) && (media < 0.05))
            {
                flag = 0;
                Console.WriteLine("FLAG 0");
            }
            else if (media > 0.05)
            {
                flag = 1;
                Console.WriteLine("FLAG 1");
            }
            else if (media < -0.05)
            {
                flag = -1;
                Console.WriteLine("FLAG -1");
            }

            // FLAG 0 => Onda T INEXISTENTE, retorna os próximos 50 pontos sem qualquer 
            // tratamento de início ou fim
            if (flag == 0)
            {
                fim = inicio + 69;
                extremosT[0] = inicio;
                extremosT[1] = fim;
            }

            // FLAG 1 => Onda T existe e é POSITIVA, precisa-se encontrar seu início e fim
            if (flag == 1)
            {
                // Encontra o fim da onda T
                bool walking = true;
                bool descendo = false;

                index = inicio + 10;

                while (walking)
                {
                    if (((onda[index + 1] +
                        onda[index + 2] +
                        onda[index + 3] +
                        onda[index + 4] +
                        onda[index + 5]) / 5) <= ((onda[index]) * 0.9))
                    {
                        descendo = true;
                    }

                    if ((descendo == true) &&
                        ((onda[index + 1] +
                        onda[index + 2] +
                        onda[index + 3] +
                        onda[index + 4] +
                        onda[index + 5]) / 5) * 1.1 >= (onda[index]))
                    {
                        index++;
                        walking = false;
                    }

                    index++;
                }

                fim = index;
                Console.WriteLine("Fim  em {0}", fim);

                // Encontra o início da onda T
                walking = true;
                index = inicio;

                while (walking)
                {
                    if (((onda[index + 1] +
                        onda[index + 2] +
                        onda[index + 3] +
                        onda[index + 4] +
                        onda[index + 5]) / 5) > ((onda[index]) * 1.1))
                    {
                        inicio = index;
                        break;
                    }

                    index++;
                }

                //inicio = index;
                Console.WriteLine("Início em {0}", inicio);

                extremosT[0] = inicio;
                extremosT[1] = fim;
            }

            // FLAG -1 => Onda T existe e é NEGATIVA, precisa-se encontrar seu início e fim
            if (flag == 1)
            {
                // Encontra o fim da onda T
                bool walking = true;

                index = inicio;

                while (walking)
                {
                    if (((onda[index + 1] +
                        onda[index + 2] +
                        onda[index + 3] +
                        onda[index + 4] +
                        onda[index + 5]) / 5) <= (onda[index] * 1.1))
                    {
                        index++;
                        walking = false;
                    }

                    index++;
                }

                fim = index;

                // Encontra o início da onda T
            }


            return extremosT;
        }

        /// <summary>
        /// Ajusta os valores do vetor, atribuindo valores próximos a zero para as áreas do ECG
        /// sem atividade cardíaca
        /// </summary>
        public void AjustarZero()
        {
            int length = vetor.Length;
            double soma = 0, media = 0;

            for (int i = 0; i < length; i++)
            {
                if ((i > 10) && (i < length - 10))
                {
                    soma = vetor[i - 10] +
                        vetor[i - 9] +
                        vetor[i - 8] +
                        vetor[i - 7] +
                        vetor[i - 6] +
                        vetor[i - 5] +
                        vetor[i - 4] +
                        vetor[i - 3] +
                        vetor[i - 2] +
                        vetor[i - 1] +
                        vetor[i] +
                        vetor[i + 1] +
                        vetor[i + 2] +
                        vetor[i + 3] +
                        vetor[i + 4] +
                        vetor[i + 5] +
                        vetor[i + 6] +
                        vetor[i + 7] +
                        vetor[i + 8] +
                        vetor[i + 9] +
                        vetor[i + 10];

                    media = soma / 21;

                    if ((vetor[i] > media * 0.8) && (vetor[i] < media * 1.2))
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                vetor[i] = vetor[i] - media;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public OndaT[] OndasT()
        {
            int[] picos = PicosQRS();
            OndaT[] ondasT = new OndaT[picos.Length];

            for (int i = 0; i < picos.Length; i++)
            {
                int[] extremos = ExtremosT(GerarVetor(), picos[i]);
                OndaT t = new OndaT(SubVetor(extremos[0], extremos[1]));
                ondasT[i] = t;
            }

            return ondasT;
        }

        /// <summary>
        /// Exibe a onda em formato binário para o Console
        /// </summary>
        public void ExbibirParaConsole()
        {
            ImagemParaArrayHelper helper = new ImagemParaArrayHelper();

            helper.ExibirParaConsole(this.Bitmap);
        }
    }
}
