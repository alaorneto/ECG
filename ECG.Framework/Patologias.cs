using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class Patologias
    {
        private Dictionary<string, string> _patologiasQRS = new Dictionary<string, string>();
        private Dictionary<string, string> _patologiasT = new Dictionary<string, string>();

        public Patologias()
        {
            _patologiasQRS.Add("NORMAL", "Normal");
            _patologiasQRS.Add("HIPERCALEM", "Hipercalemia");

            _patologiasT.Add("NORMAL", "Normal");
        }

        public Dictionary<string, string> patologiasQRS
        {
            get { return _patologiasQRS; }
        }

        public Dictionary<string, string> patologiasT
        {
            get { return _patologiasT; }
        }
    }
}
