using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// Classe representativa de um neurônio artificial, composta por uma sequência de entradas,
    /// um núcleo contendo uma função de ativação e uma saída com base no processamento das entradas
    /// pela função de ativação
    /// </summary>
    public class Neuronio
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
        protected double saida = 0;

        /// <summary>
        /// 
        /// </summary>
        protected static Random aleatorio = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <returns></returns>
        public double Calcular(double[] entradas)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Aleatorizar()
        {
            throw new NotImplementedException();
        }
    }
}
