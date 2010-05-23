using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECG.Framework.IA;

namespace ECG.Framework
{
    public static class Utils
    {
        public static int[] StringToInt(string entradas)
        {
            string[] strings = entradas.Split(';');
            int[] ints = new int[strings.Length - 1];

            for (int i = 0; i < strings.Length - 1; i++)
                ints[i] = int.Parse(strings[i]);

            return ints;
        }

        public static double[] StringToDouble(string entradas)
        {
            if (entradas == null)
                return null;

            string[] strings = entradas.Split(';');
            double[] doubs = new double[strings.Length - 1];

            for (int i = 0; i < strings.Length - 1; i++)
                doubs[i] = double.Parse(strings[i]);

            return doubs;
        }

        public static decimal[] StringToDecimal(string entradas)
        {
            string[] strings = entradas.Split(';');
            decimal[] doubs = new decimal[strings.Length - 1];

            for (int i = 0; i < strings.Length - 1; i++)
                doubs[i] = decimal.Parse(strings[i]);

            return doubs;
        }

        public static string IntToString(int[] entradas)
        {
            string s = "";

            for (int i = 0; i < entradas.Length; i++)
                s += entradas[i] + ";";

            return s;
        }

        public static string DoubleToString(double[] entradas)
        {
            string s = "";

            for (int i = 0; i < entradas.Length; i++)
                s += entradas[i] + ";";

            return s;
        }

        public static string NeuroniosToString(Rede rede)
        {
            string output = "";

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                output += rede[i].NumeroNeuronios + ";";

            }

            return output;
        }

        public static string PesosParaString(RedeAtivacao rede)
        {
            string output = "";

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    for (int k = 0; k < rede[i][j].NumeroEntradas; k++)
                    {
                        output += rede[i][j][k] + ";";
                    }
                }
            }

            return output;
        }

        public static RedeAtivacao SetupPesos(RedeAtivacao rede, string pesos)
        {
            int count = 0;
            double[] pesosarr = StringToDouble(pesos);

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    for (int k = 0; k < rede[i][j].NumeroEntradas; k++)
                    {
                        rede[i][j][k] = pesosarr[count++];
                    }
                }
            }

            return rede;
        }

        /*public static string SaidasParaString(RedeAtivacao rede)
        {
            string output = "";

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    output += rede[i][j].Saida + ";";
                }
            }

            return output;
        }

        public static RedeAtivacao SetupSaidas(RedeAtivacao rede, string saidas)
        {
            int count = 0;
            double[] saidasarr = StringToDouble(saidas);

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    rede[i][j].Saida = saidasarr[count++];
                }
            }

            return rede;
        }*/

        public static string ThresholdParaString(RedeAtivacao rede)
        {
            string output = "";

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    output += rede[i][j].Threshold + ";";
                }
            }

            return output;
        }

        public static RedeAtivacao SetupThreshold(RedeAtivacao rede, string thresholds)
        {
            if (thresholds == null)
                return rede;

            int count = 0;
            double[] saidasarr = StringToDouble(thresholds);

            for (int i = 0; i < rede.NumeroCamadas; i++)
            {
                for (int j = 0; j < rede[i].NumeroNeuronios; j++)
                {
                    rede[i][j].Threshold = saidasarr[count++];
                }
            }

            return rede;
        }


        public static double[] AproximarDiagnostico(double[] resultado)
        {
            for(int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = Math.Round(resultado[i], 0);
            }

            return resultado;
        }
    }
}
