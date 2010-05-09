using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Camada
    {
        /// <summary>
        /// 
        /// </summary>
        protected int numeroEntradas = 0;
        
        /// <summary>
        /// 
        /// </summary>
        protected int numeroNeuronios = 0;
        
        /// <summary>
        /// 
        /// </summary>
        protected Neuronio[] neuronios;
        
        /// <summary>
        /// 
        /// </summary>
        protected double[] saida;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntradas"></param>
        /// <param name="numeroNeuronios"></param>
        protected Camada(int numeroEntradas, int numeroNeuronios)
        {
            this.numeroEntradas = Math.Max(1, numeroEntradas);
            this.numeroNeuronios = Math.Max(1, numeroNeuronios);

            neuronios = new Neuronio[numeroNeuronios];

            saida = new double[numeroNeuronios];
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroEntradas { 
            get { return numeroEntradas; } 
        }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroNeuronios { 
            get { return numeroNeuronios; } 
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] Saida { 
            get { return saida; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Neuronio this[int index]
        {
            get { return neuronios[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <returns></returns>
        public virtual double[] Calcular(double[] entradas)
        {
            for (int i = 0; i < numeroNeuronios; i++)
                saida[i] = neuronios[i].Calcular(entradas);

            return saida;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Aleatorizar()
        {
            foreach(Neuronio neuronio in neuronios)
                neuronio.Aleatorizar();
        }
    }
}
