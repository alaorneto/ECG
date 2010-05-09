using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAprendizadoSupervisionado
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="saida"></param>
        /// <returns></returns>
        double Executar(double[] entrada, double[] saida);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <param name="saidas"></param>
        /// <returns></returns>
        double ExecutarEpoca(double[][] entradas, double[][] saidas);
    }
}
