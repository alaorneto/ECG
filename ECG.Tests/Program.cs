using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECG.Framework;

namespace ECG.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Neuronio neuronio = new Neuronio(new LimiarFuncaoAtivacao(), 3);

            neuronio.Entradas[0] = 1;
            neuronio.Entradas[1] = 2;
            neuronio.Entradas[2] = 3;

            for (int i = 0; i < neuronio.Entradas.Length; i++)
                Console.WriteLine(neuronio.Entradas[i]);

            Console.ReadKey();
        }
    }
}
