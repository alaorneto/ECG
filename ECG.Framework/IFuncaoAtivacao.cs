using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public interface IFuncaoAtivacao
    {
        double Calcular(double[] entradas, double[] pesos);
    }
}
