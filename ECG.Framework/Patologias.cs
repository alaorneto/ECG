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
            _patologiasT.Add(new double[4] { 0, 0, 1, 0 }, "Inexistente");
            _patologiasT.Add(new double[4] { 0, 1, 0, 0 }, "Hipercalemia");
            _patologiasT.Add(new double[4] { 1, 0, 0, 0 }, "Isquemia");
        }

        public Dictionary<double[], string> patologiasQRS
        {
            get { return _patologiasQRS; }
        }

        public Dictionary<double[], string> patologiasT
        {
            get { return _patologiasT; }
        }

        public double[] EncontrarSaidaPorNome(string nome, string onda)
        {
            double[] saida = new double[4];

            if (onda == "QRS")
            {
                foreach (var pair in _patologiasQRS)
                {
                    if (pair.Value == nome)
                        saida = pair.Key;
                }
            }

            else if (onda == "T")
            {
                foreach (var pair in _patologiasT)
                {
                    if (pair.Value == nome)
                        saida = pair.Key;
                }
            }

            return saida;

        }

        public string EncontrarNomePorSaida(double[] saida, string onda)
        {
            string nome = "Não localizado";

            if (onda == "QRS")
            {
                foreach (var pair in _patologiasQRS)
                {
                    double[] target = pair.Key;
                    bool igual = true;

                    for (int i = 0; i < target.Length; i++)
                    {
                        if (target[i] != saida[i])
                            igual = false;
                    }

                    if (igual)
                        nome = pair.Value;
                }
            }

            else if (onda == "T")
            {
                foreach (var pair in _patologiasT)
                {
                    double[] target = pair.Key;
                    bool igual = true;

                    for (int i = 0; i < target.Length; i++)
                    {
                        if (target[i] != saida[i])
                            igual = false;
                    }

                    if (igual)
                        nome = pair.Value;
                }
            }

            return nome;
        }
    }
}
