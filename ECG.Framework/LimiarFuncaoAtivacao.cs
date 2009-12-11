using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class LimiarFuncaoAtivacao: IFuncaoAtivacao
    {

        public float Calcular(float[] entradas, float[] pesos)
        {
            float soma = 0;

            for (int i = 0; i < entradas.Length; i++)
                soma = entradas[i] * pesos[i];

            if (soma >= 0)
                return 1;
            else
                return 0;
        }

    }
}
