using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public class SigmoideFuncaoAtivacao : IFuncaoAtivacao
    {
        /// <summary>
        /// 
        /// </summary>
        protected double alfa = 2;

        /// <summary>
        /// 
        /// </summary>
        public double Alfa
        {
            get { return this.alfa; }
            set { this.alfa = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public SigmoideFuncaoAtivacao() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alfa"></param>
        public SigmoideFuncaoAtivacao(double alfa)
        {
            this.alfa = alfa;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Funcao(double x)
        {
            double exp = Math.Exp(-alfa * x);
            double saida = (1 / (1 + exp));
            return saida;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Derivada(double x)
        {
            double y = Funcao(x);

            return (this.alfa * y * (1 - y));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Derivada2(double y)
        {
            return (this.alfa * y * (1 - y));
        }

    }
}
