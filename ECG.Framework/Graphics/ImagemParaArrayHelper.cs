﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ECG.Framework.Graphics
{
    /// <summary>
    /// 
    /// </summary>
    public class ImagemParaArrayHelper
    {
        double[,] _matriz;
        Bitmap _imagem;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        public double[,] GerarArray(Bitmap imagem)
        {
            return GerarArray(imagem, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
        /// <param name="loops"></param>
        /// <returns></returns>
        public double[,] GerarArray(Bitmap imagem, int loops)
        {
            ConversaoHelper helper = new ConversaoHelper();

            this._imagem = helper.Binary(imagem);

            if (loops < 1)
                throw new InvalidOperationException("Quantidade de loops precisa ser igual ou maior que 1");
            
            ConverterParaMatriz();

            ConverterMatrizParaInteiros();

            for(int x = 0; x < loops; x++)
                RemoverRuidos();

            return _matriz;
        }

        /// <summary>
        /// 
        /// </summary>
        protected void ConverterParaMatriz()
        {
            _matriz = new double[this._imagem.Width, this._imagem.Height];

            BitmapData bmData = _imagem.LockBits(new Rectangle(0, 0, _imagem.Width, _imagem.Height), ImageLockMode.ReadWrite, _imagem.PixelFormat);

            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - _imagem.Width * 3;

                for (int y = 0; y < _imagem.Height; ++y)
                {
                    for (int x = 0; x < _imagem.Width; ++x)
                    {
                        _matriz[x, y] = p[0];

                        p += 3;
                    }

                    p += nOffset;
                }
            }

            _imagem.UnlockBits(bmData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected double[,] ConverterMatrizParaInteiros()
        {
            for (int x = 0; x < _imagem.Width; ++x)
            {
                for (int y = 0; y < _imagem.Height; ++y)
                {
                    if (_matriz[x, y] == (double)0)
                        _matriz[x, y] = 1;
                    else
                        _matriz[x, y] = 0;
                }
            }

            return _matriz;
        }

        /// <summary>
        /// 
        /// </summary>
        protected void RemoverRuidos()
        {
            for (int x = 0; x < _imagem.Width; x++)
            {
                for (int y = 0; y < _imagem.Height; y++)
                {
                    double soma = 0;

                    if (_matriz[x, y] == 1)
                    {
                        if ((x == 0) && (y == 0))
                        {
                            soma = _matriz[x, y + 1] +
                                _matriz[x + 1, y] +
                                _matriz[x + 1, y + 1];
                        }
                        else if ((x == 0) && (y != 0) && (y != _imagem.Height - 1))
                        {
                            soma = _matriz[x, y - 1] +
                                _matriz[x, y + 1] +
                                _matriz[x + 1, y - 1] +
                                _matriz[x + 1, y] +
                                _matriz[x + 1, y + 1];
                        }

                        else if ((x == 0) && (y == _imagem.Height - 1))
                        {
                            soma = _matriz[x, y - 1] +
                                _matriz[x, y] +
                                _matriz[x + 1, y - 1] +
                                _matriz[x + 1, y];
                        }
                        else if ((x != 0) && (x != (_imagem.Width - 1)) && (y != 0) && (y != (_imagem.Height - 1)))
                        {
                            soma = _matriz[x - 1, y - 1] +
                                _matriz[x - 1, y] +
                                _matriz[x - 1, y + 1] +
                                _matriz[x, y - 1] +
                                _matriz[x, y + 1] +
                                _matriz[x + 1, y - 1] +
                                _matriz[x + 1, y] +
                                _matriz[x + 1, y + 1];
                        }
                        else if ((x == _imagem.Width - 1) && (y == _imagem.Height - 1))
                        {
                            soma = _matriz[x - 1, y - 1] +
                               _matriz[x - 1, y] +
                               _matriz[x, y - 1];
                        }
                        else if ((x != 0) && (x == (_imagem.Width - 1)) && (y == 0))
                        {
                            soma = _matriz[x - 1, y] +
                                _matriz[x, y] +
                                _matriz[x - 1, y + 1] +
                                _matriz[x, y + 1];
                        }
                        else if ((x != 0) && (y == 0))
                        {
                            soma = _matriz[x - 1, y] +
                                _matriz[x + 1, y] +
                                _matriz[x - 1, y + 1] +
                                _matriz[x, y + 1] +
                                _matriz[x + 1, y + 1];
                        }
                        else if ((x == _imagem.Width - 1) && (y != _imagem.Height - 1))
                        {
                            soma = _matriz[x - 1, y - 1] +
                                _matriz[x - 1, y] +
                                _matriz[x - 1, y + 1] +
                                _matriz[x, y - 1] +
                                _matriz[x, y + 1];
                        }
                        else if ((x != _imagem.Width - 1) && (y == _imagem.Height - 1))
                        {
                            soma = _matriz[x - 1, y - 1] +
                               _matriz[x, y - 1] +
                               _matriz[x + 1, y - 1] +
                               _matriz[x - 1, y] +
                               _matriz[x + 1, y];
                        }
                        if (soma > 2)
                            _matriz[x, y] = 1;
                        else
                            _matriz[x, y] = 0;
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void ExibirParaConsole(Bitmap imagem)
        {
            GerarArray(imagem);

            for (int x = 0; x < _imagem.Height; ++x)
            {
                for (int y = 0; y < _imagem.Width; y++)
                {
                    Console.Write(_matriz[y, x]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        public double[] GerarVetor(Bitmap imagem)
        {
            double[] vetor = new double[imagem.Width];

            this.GerarArray(imagem);

            for (int x = 0; x < _imagem.Width; x++)
            {
                double count = 0, indices = 0;

                for (int y = 0; y < _imagem.Height; y++)
                {
                    if (_matriz[x, y] == 1)
                    {
                        count++;
                        indices += _imagem.Height - y;
                    }
                }
                if (count == 0)
                    vetor[x] = 0;
                else
                    vetor[x] = (indices / count)/50;
            }

            return vetor;
        }
    }
}
