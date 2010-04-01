using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class RedeAtivacao : Rede
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new CamadaAtivacao this[int index]
        {
            get { return ((CamadaAtivacao)_camadas[index]); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcaoAtivacao"></param>
        /// <param name="numeroEntradas"></param>
        /// <param name="numeroNeuronios"></param>
        public RedeAtivacao(IFuncaoAtivacao funcaoAtivacao, int numeroEntradas, params int[] numeroNeuronios) 
            : base(numeroEntradas, numeroNeuronios.Length)
        {
            for (int i = 0; i < _numeroCamadas; i++)
            {
                _camadas[i] = new CamadaAtivacao((i == 0) ? numeroEntradas : numeroNeuronios[i - 1],
                                                    numeroNeuronios[i],
                                                    funcaoAtivacao);
            }
        }
    }
}
