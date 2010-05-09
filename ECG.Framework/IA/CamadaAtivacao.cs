using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
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
            get { return (NeuronioAtivacao)neuronios[index]; }
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
                this.neuronios[i] = new NeuronioAtivacao(numeroEntradas, funcaoAtivacao);
        }
    }
}
