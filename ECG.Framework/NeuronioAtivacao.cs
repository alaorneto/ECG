using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class NeuronioAtivacao : Neuronio
    {
        protected double _threshold = 0.0f;

        protected IFuncaoAtivacao _funcao = null;

        public double Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        public IFuncaoAtivacao FuncaoAtivacao
        {
            get { return this._funcao; }
        }

        public NeuronioAtivacao(int numeroEntradas, IFuncaoAtivacao funcaoAtivacao)
            : base(numeroEntradas)
        {
            this._funcao = funcaoAtivacao;
        }

        public override double Calcular(double[] entradas)
        {
            if (entradas.Length != this._numeroEntradas)
                throw new ArgumentException();

            double soma = 0.0;

            for (int i = 0; i < _numeroEntradas; i++)
                soma += _pesos[i] * entradas[i];

            soma += _threshold;

            return (_saida = _funcao.Funcao(soma));
        }

        public override void Aleatorizar()
        {
            double d = randRange.Length;

            for (int i = 0; i < _numeroEntradas; i++)
                _pesos[i] = aleatorio.NextDouble() * d + randRange.Min;
        }
    }
}
