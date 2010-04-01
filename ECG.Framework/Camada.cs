using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class Camada
    {
        protected int _numeroEntradas = 0;
        protected int _numeroNeuronios = 0;
        protected Neuronio[] _neuronios;
        protected double[] _saida;

        public Camada(int numeroEntradas, int numeroNeuronios)
        {
            this._numeroEntradas = Math.Max(1, numeroEntradas);
            this._numeroNeuronios = Math.Max(1, numeroNeuronios);

            this._neuronios = new Neuronio[numeroNeuronios];

            this._saida = new double[numeroNeuronios];
        }

        public int NumeroEntradas { 
            get { return _numeroEntradas; } 
        }

        public int NumeroNeuronios { 
            get { return _numeroNeuronios; } 
        }

        public double[] Saida { 
            get { return _saida; }
        }

        public Neuronio this[int index]
        {
            get { return _neuronios[index]; }
        }

        public double[] Calcular(double[] entradas)
        {
            for (int i = 0; i < _numeroNeuronios; i++)
                _saida[i] = _neuronios[i].Calcular(entradas);

            return _saida;
        }

        public void Aleatorizar()
        {
            foreach(Neuronio neuronio in _neuronios)
                neuronio.Aleatorizar();
        }
    }
}
