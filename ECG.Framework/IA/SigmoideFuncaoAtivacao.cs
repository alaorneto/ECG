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
        protected double _alfa = 2;

        /// <summary>
        /// 
        /// </summary>
        public double Alfa
        {
            get { return this._alfa; }
            set { this._alfa = value; }
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
            this._alfa = alfa;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Funcao(double x)
        {
            return (1 / (1 + Math.Exp(-_alfa * x)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Derivada(double x)
        {
            double y = Funcao(x);

            return (this._alfa * y * (1 - y));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Derivada2(double y)
        {
            return (this._alfa * y * (1 - y));
        }

    }
}
