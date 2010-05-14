using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Rede
    {
        /// <summary>
        /// 
        /// </summary>
        protected string _descricao;

        /// <summary>
        /// 
        /// </summary>
        protected int _numeroEntradas;

        /// <summary>
        /// 
        /// </summary>
        protected int _numeroCamadas;

        /// <summary>
        /// 
        /// </summary>
        protected double[] _saida;

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
            this._numeroEntradas = Math.Max(1, numeroEntradas);
            this._numeroCamadas = Math.Max(1, numeroCamadas);

            this._camadas = new Camada[this.NumeroCamadas];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">Índice referente a camada desejada</param>
        /// <returns></returns>
        public Camada this[int index]
        {
            get { return this._camadas[index]; }
        }

        public string Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroEntradas
        {
            get { return this._numeroEntradas; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroCamadas
        {
            get { return this._numeroCamadas; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] Saida
        {
            get { return this._saida; }
        }

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
