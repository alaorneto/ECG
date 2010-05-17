using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    public class BipolarSigmoideFuncaoAtivacao : IFuncaoAtivacao
    {
        private double alpha = 2;

        public double Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public BipolarSigmoideFuncaoAtivacao() { }

        public BipolarSigmoideFuncaoAtivacao(double alpha)
        {
            this.alpha = alpha;
        }

        public double Funcao(double x)
        {
            return ((2 / (1 + Math.Exp(-alpha * x))) - 1);
        }

        public double Derivada(double x)
        {
            double y = Funcao(x);

            return (alpha * (1 - y * y) / 2);
        }

        public double Derivada2(double y)
        {
            return (alpha * (1 - y * y) / 2);
        }
    }
}
