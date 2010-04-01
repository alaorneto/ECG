using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public class CamadaAtivacao : Camada
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new NeuronioAtivacao this[int index]
        {
            get { return (NeuronioAtivacao)_neuronios[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntradas"></param>
        /// <param name="numeroNeuronios"></param>
        /// <param name="funcaoAtivacao"></param>
        public CamadaAtivacao(int numeroEntradas, int numeroNeuronios, IFuncaoAtivacao funcaoAtivacao)
            : base(numeroEntradas, numeroNeuronios)
        {
            for (int i = 0; i < numeroNeuronios; i++)
                this._neuronios[i] = new NeuronioAtivacao(numeroEntradas, funcaoAtivacao);
        }
    }
}
