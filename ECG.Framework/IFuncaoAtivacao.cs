using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public interface IFuncaoAtivacao
    {
        float Calcular(float[] entradas, float[] pesos);
    }
}
