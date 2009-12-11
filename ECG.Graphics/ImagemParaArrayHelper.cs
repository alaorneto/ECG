using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ECG.Graphics
{
    public class ImagemParaArrayHelper
    {
        public float[] GerarArray(Bitmap imagem)
        {
            bool DEBUG = false;
            
            float[,] matriz = new float[imagem.Width, imagem.Height];

            imagem.RotateFlip(RotateFlipType.Rotate90FlipNone);

            BitmapData bmData = imagem.LockBits(new Rectangle(0, 0, imagem.Width, imagem.Height), ImageLockMode.ReadWrite, imagem.PixelFormat);

            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - imagem.Width * 3;

                for (int y = 0; y < imagem.Height; ++y)
                {
                    for (int x = 0; x < imagem.Width; ++x)
                    {
                        if(DEBUG)
                            Console.Write(p[0] + " ");

                        matriz[y, x] = p[0];

                        p += 3;
                    }
                    
                    if(DEBUG)
                        Console.WriteLine("\nLINE " + y + "\n");
                    
                    p += nOffset;
                }
            }

            imagem.UnlockBits(bmData);

            // Loop 1, transformando matriz de float em inteiro

            for (int y = 0; y < imagem.Height; ++y)
            {
                for (int x = 0; x < imagem.Width; ++x)
                {
                    if (matriz[y, x] == (float)0)
                        matriz[y, x] = 1;
                    else
                        matriz[y, x] = 0;
                }
            }

            // Loop 2, removendo ruídos

            for (int y = 0; y < imagem.Height; ++y)
            {
                for (int x = 0; x < imagem.Width; ++x)
                {
                    float soma;

                    if (matriz[y, x] == 1)
                    {
                        if ((x == 0) && (y == 0))
                        {
                            soma = matriz[y, x + 1] +
                                matriz[y + 1, x] +
                                matriz[y + 1, x + 1];
                        }
                        else if ((x != 0) && (x == imagem.Width - 1) && (y == 0))
                        {
                            soma = matriz[y, x - 1] +
                                matriz[y + 1, x - 1] +
                                matriz[y + 1, x];
                        }
                        else if ((x == 0) && (y != 0) && (y != imagem.Height - 1))
                        {
                            soma = matriz[y - 1, x] +
                                matriz[y - 1, x + 1] +
                                matriz[y, x + 1];
                        }
                        else if ((x == 0) && (y != 0))
                        {
                            soma = matriz[y - 1, x] +
                                matriz[y - 1, x + 1] +
                                matriz[y, x + 1] +
                                matriz[y + 1, x] +
                                matriz[y + 1, x + 1];
                        }
                        else if ((x != 0)  && (y == 0))
                        {
                            soma = matriz[y, x - 1] +
                                matriz[y, x + 1] +
                                matriz[y + 1, x - 1] +
                                matriz[y + 1, x] +
                                matriz[y + 1, x + 1];
                        }
                        else if ((x == imagem.Width - 1) && (y == imagem.Height - 1))
                        {
                            soma = matriz[y - 1, x - 1] +
                               matriz[y - 1, x] +
                               matriz[y, x - 1];
                        }
                        else if ((x == imagem.Width - 1) && (y != imagem.Height - 1))
                        {
                            soma = matriz[y - 1, x - 1] +
                                matriz[y - 1, x] +
                                matriz[y, x - 1] +
                                matriz[y + 1, x - 1] +
                                matriz[y + 1, x];
                        }
                        else if ((x != imagem.Width - 1) && (y == imagem.Height - 1))
                        {
                            soma = matriz[y - 1, x - 1] +
                               matriz[y - 1, x] +
                               matriz[y - 1, x + 1] +
                               matriz[y, x - 1] +
                               matriz[y, x + 1];
                        }
                        else
                        {
                            soma = matriz[y - 1, x - 1] +
                                matriz[y - 1, x] +
                                matriz[y - 1, x + 1] +
                                matriz[y, x - 1] +
                                matriz[y, x + 1] +
                                matriz[y + 1, x - 1] +
                                matriz[y + 1, x] +
                                matriz[y + 1, x + 1];
                        }
                        if (soma > 2)
                            matriz[y, x] = 1;
                        else
                            matriz[y, x] = 0;
                    }
                }
            }


            for (int y = imagem.Width - 1; y >= 0; --y)
            {
                for (int x = 0; x < imagem.Height; ++x)
                {
                    Console.Write(matriz[x, y]);
                }

                Console.WriteLine();
            }

            return null;
        }
    }
}
