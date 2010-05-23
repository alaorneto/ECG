﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Neuronio
    {
        /// <summary>
        /// 
        /// </summary>
        protected int _numeroEntradas = 0;

        /// <summary>
        /// 
        /// </summary>
        protected double[] _pesos = null;

        /// <summary>
        /// 
        /// </summary>
        protected double _saida = 0;

        /// <summary>
        /// 
        /// </summary>
        protected static Random aleatorio = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// 
        /// </summary>
        protected static DoubleRange randRange = new DoubleRange(0.0, 1.0);

        public Neuronio(int numeroEntradas)
        {
            this._numeroEntradas = Math.Max(1, numeroEntradas);
            this._pesos = new double[numeroEntradas];
            this.Aleatorizar();
        }

        /// <summary>
        /// 
        /// </summary>
        public static Random RandGenerator
        {
            get { return aleatorio; }
            set
            {
                if (value != null)
                {
                    aleatorio = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static DoubleRange RandRange
        {
            get { return randRange; }
            set
            {
                if (value != null)
                {
                    randRange = value;
                }
            }
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
        public double Saida
        {
            get { return this._saida; }
        }

        /// <summary>
        /// Peso
        /// </summary>
        /// <param name="index"></param>
        /// <returns>O peso associado à entrada</returns>
        public double this[int index]
        {
            get { return this._pesos[index]; }
            set { this._pesos[index] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <returns></returns>
        public abstract double Calcular(double[] entradas);

        /// <summary>
        /// 
        /// </summary>
        public virtual void Aleatorizar()
        {
            double d = randRange.Length;

            for (int i = 0; i < _numeroEntradas; i++)
                this._pesos[i] = (aleatorio.NextDouble() * d + randRange.Min);
        }
    }
}
