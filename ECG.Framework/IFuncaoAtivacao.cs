using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFuncaoAtivacao
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double Funcao(double x);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double Derivada(double x);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        double Derivada2(double y);
    }
}
