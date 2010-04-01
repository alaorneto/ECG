using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Rede
    {
        /// <summary>
        /// 
        /// </summary>
        protected Camada[] _camadas;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntradas">Número de entradas da rede</param>
        /// <param name="numeroCamadas">Número de camadas da rede</param>
        public Rede(int numeroEntradas, int numeroCamadas)
        {
            this.NumeroEntradas = Math.Max(1, numeroEntradas);
            this.NumeroCamadas = Math.Max(1, numeroCamadas);

            this._camadas = new Camada[this.NumeroCamadas];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">Índice referente a camada desejada</param>
        /// <returns></returns>
        protected Camada this[int index]
        {
            get { return this._camadas[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroEntradas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroCamadas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas">Vetor de entradas a serem usadas no cálculo</param>
        /// <returns></returns>
        public virtual double[] Calcular(double[] entradas)
        {
            double[] saidas = entradas;

            foreach (Camada camada in _camadas)
                saidas = camada.Calcular(saidas);

            return saidas;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Aleatorizar()
        {
            foreach (Camada camada in _camadas)
                camada.Aleatorizar();
        }
    }
}
