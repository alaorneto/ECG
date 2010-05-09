using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ECG.Framework
{
    /// <summary>
    /// Classe Helper para prover métodos auxiliares no processamento de conversões em arquivos do tipo Bitmap
    /// </summary>
    public class ConversaoHelper
    {
        /// <summary>
        /// Transforma um objeto Bitmap em um correspondente na escala de cinzas, removendo informações de cores
        /// </summary>
        /// <param name="imagem">Objeto Bitmap correspondente a imagem a ser convertida</param>
        /// <returns></returns>
        public Bitmap GrayScale(Bitmap imagem)
        {
            Bitmap gray = SetupGrayScale(imagem);

            return gray;
        }

        /// <summary>
        /// Método interno responsável por realizar o trabalho atribuído ao método público GrayScale
        /// </summary>
        /// <param name="imagem">Objeto Bitmap correspondente a imagem a ser convertida</param>
        /// <returns></returns>
        private Bitmap SetupGrayScale(Bitmap imagem)
        {
            BitmapData bmData = imagem.LockBits(new Rectangle(0, 0, imagem.Width, imagem.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - imagem.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < imagem.Height; ++y)
                {
                    for (int x = 0; x < imagem.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            imagem.UnlockBits(bmData);

            return imagem;
        }

        /// <summary>
        /// Transforma um objeto Bitmap em um correspondente no padrão binário, com informações de bit ativado ou desativado, apenas
        /// </summary>
        /// <param name="imagem">Objeto Bitmap correspondente a imagem a ser convertida</param>
        /// <returns></returns>
        public Bitmap Binary(Bitmap imagem)
        {
            Bitmap binary = SetupBinary(imagem, true);

            return binary;
        }

        /// <summary>
        /// Método interno responsável por realizar o trabalho atribuído ao método público Binary
        /// </summary>
        /// <param name="imagem">Objeto Bitmap correspondente a imagem a ser convertida</param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private Bitmap SetupBinary(Bitmap imagem, bool flag)
        {
            BitmapData bmData = imagem.LockBits(new Rectangle(0, 0, imagem.Width, imagem.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;

            int threshold = 220;
            
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - imagem.Width * 3;

                byte red, green, blue;
                byte binary;

                for (int y = 0; y < imagem.Height; ++y)
                {
                    for (int x = 0; x < imagem.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        binary = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);

                        if (binary < threshold && flag)
                            p[0] = p[1] = p[2] = 0;
                        else
                            if (binary >= threshold && flag)
                                p[0] = p[1] = p[2] = 255;
                            else
                                if (binary < threshold && !flag)
                                    p[0] = p[1] = p[2] = 255;
                                else
                                    p[0] = p[1] = p[2] = 0;
                        p += 3;
                    }
                    p += nOffset;
                }

            }

            imagem.UnlockBits(bmData);

            return imagem;
        }
    }
}
