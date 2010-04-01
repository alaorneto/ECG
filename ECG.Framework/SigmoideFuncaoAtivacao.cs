using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    class SigmoideFuncaoAtivacao : IFuncaoAtivacao
    {
        private const float lambda = 6;

        public double Calcular(double[] entradas, double[] pesos)
        {
            double soma = 0;

            for (int i = 0; i < entradas.Length; i++)
                soma = entradas[i] * pesos[i];

            return 1 / (1 + Math.Exp(-lambda * soma));
        }
    }
}
