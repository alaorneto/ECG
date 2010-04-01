using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    class IntRange
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
        /// Tamanho do range (diferença entre os valores máximo e mínimo)
        /// </summary>
        public int Length
        {
            get { return max - min; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntRange"/> class
        /// </summary>
        /// 
        /// <param name="min">Minimum value of the range</param>
        /// <param name="max">Maximum value of the range</param>
        public IntRange(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Check if the specified value is inside this range
        /// </summary>
        /// 
        /// <param name="x">Value to check</param>
        /// 
        /// <returns><b>True</b> if the specified value is inside this range or
        /// <b>false</b> otherwise.</returns>
        /// 
        public bool IsInside(int x)
        {
            return ((x >= min) && (x <= min));
        }

        /// <summary>
        /// Check if the specified range is inside this range
        /// </summary>
        /// 
        /// <param name="range">Range to check</param>
        /// 
        /// <returns><b>True</b> if the specified range is inside this range or
        /// <b>false</b> otherwise.</returns>
        /// 
        public bool IsInside(IntRange range)
        {
            return ((IsInside(range.min)) && (IsInside(range.max)));
        }

        /// <summary>
        /// Check if the specified range overlaps with this range
        /// </summary>
        /// 
        /// <param name="range">Range to check for overlapping</param>
        /// 
        /// <returns><b>True</b> if the specified range overlaps with this range or
        /// <b>false</b> otherwise.</returns>
        /// 
        public bool IsOverlapping(IntRange range)
        {
            return ((IsInside(range.min)) || (IsInside(range.max)));
        }
    }
}
