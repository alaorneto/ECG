using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    /// <summary>
    /// Esta classe oferece serviços para faixas de valores inteiros
    /// </summary>
    public class IntRange
    {
        private int min, max;

        /// <summary>
        /// Valor mínimo
        /// </summary>
        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        /// <summary>
        /// Valor máximo
        /// </summary>
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        /// <summary>
        /// Tamanho da faixa (diferença entre os valores máximo e mínimo)
        /// </summary>
        public int Length
        {
            get { return max - min; }
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IntRange"/>
        /// </summary>
        /// <param name="min">Valor mínimo da faixa</param>
        /// <param name="max">Valor máximo da faixa</param>
        public IntRange(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Checa se o valor especificado está dentro desta faixa
        /// </summary>
        /// <param name="x">Valor a ser checado</param>
        /// <returns><b>true</b> se o valor especificado está dentro desta faixa ou
        /// <b>false</b> caso contrário</returns>
        public bool IsInside(int x)
        {
            return ((x >= min) && (x <= min));
        }

        /// <summary>
        /// Checa se a faixa especificada está dentro desta faixa
        /// </summary>
        /// <param name="range">Faixa a ser checada</param>
        /// <returns><b>true</b> se a faixa especificada está dentro desta faixa ou
        /// <b>false</b> caso contrário</returns>
        public bool IsInside(IntRange range)
        {
            return ((IsInside(range.min)) && (IsInside(range.max)));
        }

        /// <summary>
        /// Checa se a faixa especificada ultrapassa os limites desta faixa
        /// </summary>
        /// <param name="range">Faixa a ser checada</param>
        /// <returns><b>true</b> se a faixa especificada ultrapassa os limites desta faixa ou 
        /// <b>false</b> caso contrário</returns>
        public bool IsOverlapping(IntRange range)
        {
            return ((IsInside(range.min)) || (IsInside(range.max)));
        }
    }
}
