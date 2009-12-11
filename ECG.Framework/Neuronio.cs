using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// Classe representativa de um neurônio artificial, composta por uma sequência de entradas,
    /// um núcleo contendo uma função de ativação e uma saída com base no processamento das entradas
    /// pela função de ativação
    /// </summary>
    public class Neuronio
    {
        /// <summary>
        /// Variável privada que armazena a instância do tipo IFuncaoAtivacao indicada
        /// para o neurôneo
        /// </summary>
        private IFuncaoAtivacao m_funcaoAtivacao;

        private float[] m_entradas;
        private float[] m_pesos;

        private float bias = 1;

        /// <summary>
        /// Construtor da classe Neuronio com um parâmetro para determinar a função de ativação a ser
        /// usada no neurôneo
        /// </summary>
        /// <param name="funcaoAtivacao">Função de ativação do tipo IFuncaoAtivacao</param>
        /// <param name="entradas">Número de entradas do neurônio</param>
        public Neuronio(IFuncaoAtivacao funcaoAtivacao, int entradas)
            : this(entradas)
        {
            this.m_funcaoAtivacao = funcaoAtivacao;
        }

        /// <summary>
        /// Construtor padrão da classe Neuronio que assume uma função de ativação padrão (LimiarFuncaoAtivacao)
        /// na criação de uma nova instância
        /// </summary>
        /// <param name="entradas">Número de entradas do neurônio</param>
        public Neuronio(int entradas)
        {
            this.m_entradas = new float[entradas];
            this.m_pesos = new float[entradas];
            this.m_funcaoAtivacao = new LimiarFuncaoAtivacao();
            
            Entradas[0] = bias;
        }

        /// <summary>
        /// Vetor de entradas do neurônio do tipo float
        /// </summary>
        public float[] Entradas
        {
            get
            {
                return this.m_entradas;
            }
        }

        /// <summary>
        /// Saída do neurônio após processamento das entradas pela função de ativação
        /// </summary>
        public float Saida { get; set; }
    }
}
