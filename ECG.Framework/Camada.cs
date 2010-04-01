using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Camada
    {
        /// <summary>
        /// 
        /// </summary>
        protected int _numeroEntradas = 0;
        
        /// <summary>
        /// 
        /// </summary>
        protected int _numeroNeuronios = 0;
        
        /// <summary>
        /// 
        /// </summary>
        protected Neuronio[] _neuronios;
        
        /// <summary>
        /// 
        /// </summary>
        protected double[] _saida;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntradas"></param>
        /// <param name="numeroNeuronios"></param>
        protected Camada(int numeroEntradas, int numeroNeuronios)
        {
            this._numeroEntradas = Math.Max(1, numeroEntradas);
            this._numeroNeuronios = Math.Max(1, numeroNeuronios);

            this._neuronios = new Neuronio[numeroNeuronios];

            this._saida = new double[numeroNeuronios];
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroEntradas { 
            get { return _numeroEntradas; } 
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroNeuronios { 
            get { return _numeroNeuronios; } 
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] Saida { 
            get { return _saida; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Neuronio this[int index]
        {
            get { return _neuronios[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <returns></returns>
        public virtual double[] Calcular(double[] entradas)
        {
            for (int i = 0; i < _numeroNeuronios; i++)
                _saida[i] = _neuronios[i].Calcular(entradas);

            return _saida;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Aleatorizar()
        {
            foreach(Neuronio neuronio in _neuronios)
                neuronio.Aleatorizar();
        }
    }
}
