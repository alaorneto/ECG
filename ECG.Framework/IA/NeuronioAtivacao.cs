using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public class NeuronioAtivacao : Neuronio
    {
        protected double _threshold = 0.0f;

        protected IFuncaoAtivacao _funcao = null;

        /// <summary>
        /// 
        /// </summary>
        public double Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public IFuncaoAtivacao FuncaoAtivacao
        {
            get { return this._funcao; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntradas"></param>
        /// <param name="funcaoAtivacao"></param>
        public NeuronioAtivacao(int numeroEntradas, IFuncaoAtivacao funcaoAtivacao)
            : base(numeroEntradas)
        {
            this._funcao = funcaoAtivacao;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <returns></returns>
        public override double Calcular(double[] entradas)
        {
            if (entradas.Length != this._numeroEntradas)
                throw new ArgumentException();

            double soma = 0.0;

            for (int i = 0; i < _numeroEntradas; i++)
                soma += _pesos[i] * entradas[i];

            soma += _threshold;

            return (_saida = _funcao.Funcao((double)soma));
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Aleatorizar()
        {
            double d = randRange.Length;

            for (int i = 0; i < _numeroEntradas; i++)
                _pesos[i] = (aleatorio.NextDouble() * d + randRange.Min);
        }
    }
}
