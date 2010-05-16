using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class Patologias
    {

        private Dictionary<double[], string> _patologiasQRS = new Dictionary<double[], string>();
        private Dictionary<double[], string> _patologiasT = new Dictionary<double[], string>();

        public Patologias()
        {
            _patologiasQRS.Add(new double[4] { 0, 0, 0, 1 }, "Normal");
            _patologiasQRS.Add(new double[4] { 0, 0, 1, 0 }, "Extra-Sístole Ventricular");

            _patologiasT.Add(new double[4] { 0, 0, 0, 1 }, "Normal");
        }

        public Dictionary<double[], string> patologiasQRS
        {
            get { return _patologiasQRS; }
        }

        public Dictionary<double[], string> patologiasT
        {
            get { return _patologiasT; }
        }
    }
}
