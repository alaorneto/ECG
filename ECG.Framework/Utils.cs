using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public static class Utils
    {
        public static int[] StringToInt(string entradas)
        {
            string[] strings = entradas.Split(';');
            int[] ints = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
                ints[i] = int.Parse(strings[i]);

            return ints;
        }

        public static double[] StringToDouble(string entradas)
        {
            string[] strings = entradas.Split(';');
            double[] doubs = new double[strings.Length];

            for (int i = 0; i < strings.Length; i++)
                doubs[i] = int.Parse(strings[i]);

            return doubs;
        }

        public static string IntToString(int[] entradas)
        {
            string s = "";

            for (int i = 0; i < entradas.Length; i++)
                s = entradas[i] + ";";

            return s;
        }

        public static string DoubleToString(double[] entradas)
        {
            string s = "";

            for (int i = 0; i < entradas.Length; i++)
                s = entradas[i] + ";";

            return s;
        }


    }
}
