using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    /// <summary>
    /// 
    /// </summary>
    class AprendizadoBackPropagation
    {
        private RedeAtivacao rede;

        private double taxaAprendizado = 0.1;

        private double momentum = 0.0;

        private double[][] erroNeuronio = null;

        private double[][][] atualizacaoPesos = null;

        private double[][] atualizacaoThreshold = null;

        /// <summary>
        /// 
        /// </summary>
        private double TaxaAprendizado
        {
            get { return taxaAprendizado; }
            set { taxaAprendizado = Math.Max(0.0, Math.Min(1.0, value)); }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Momentum
        {
            get { return momentum; }
            set { momentum = Math.Max(0.0, Math.Min(1.0, value)); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rede"></param>
        public AprendizadoBackPropagation(RedeAtivacao rede)
        {
            this.rede = rede;

            // Cria as matrizes de erro e delta
            erroNeuronio = new double[rede.NumeroCamadas][];
            atualizacaoPesos = new double[rede.NumeroCamadas][][];
            atualizacaoThreshold = new double[rede.NumeroCamadas][];

            // Inicializa as matrizes de erro e delta para cada camada
            for(int i = 0; i < rede.NumeroCamadas; i++)
            {
                Camada camada = rede[i];

                erroNeuronio[i] = new double[camada.NumeroNeuronios];
                atualizacaoPesos[i] = new double[camada.NumeroNeuronios][];
                atualizacaoThreshold[i] = new double[camada.NumeroNeuronios];

                // Para cada neurônio
                for (int j = 0; j < camada.NumeroNeuronios; j++)
                {
                    atualizacaoPesos[i][j] = new double[camada.NumeroEntradas];
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="saida"></param>
        /// <returns></returns>
        public double Executar(double[] entrada, double[] saida)
        {
            rede.Calcular(entrada);

            double erro = CalcularErro(saida);

            CalcularAtualizacoes(entrada);

            AtualizarRede();

            return erro;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas"></param>
        /// <param name="saidas"></param>
        /// <returns></returns>
        public double ExecutarEpoca(double[][] entradas, double[][] saidas)
        {
            double erro = 0.0;

            for (int i = 0; i < entradas.Length; i++)
            {
                erro += Executar(entradas[i], saidas[i]);
            }

            return erro;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saidaDesejada"></param>
        /// <returns></returns>
        private double CalcularErro(double[] saidaDesejada)
        {
            CamadaAtivacao camada, proximaCamada;
            double[] erros, proximosErros;
            double erro = 0, e, soma;
            double saida;
            int NumeroCamadas = rede.NumeroCamadas;
            IFuncaoAtivacao funcao = rede[0][0].FuncaoAtivacao;

            camada = rede[NumeroCamadas - 1];
            erros = erroNeuronio[NumeroCamadas - 1];

            for (int i = 0; i < camada.NumeroNeuronios; i++)
            {
                saida = camada[i].Saida;
                e = saidaDesejada[i] - saida;
                erros[i] = e * funcao.Derivada2(saida);
                erro += (e * e);
            }

            for (int j = NumeroCamadas - 2; j >= 0; j--)
            {
                camada = rede[j];
                proximaCamada = rede[j + 1];
                erros = erroNeuronio[j];
                proximosErros = erroNeuronio[j + 1];

                for (int i = 0; i < camada.NumeroNeuronios; i++)
                {
                    soma = 0.0;

                    for (int k = 0; k < proximaCamada.NumeroNeuronios; k++)
                    {
                        soma += proximosErros[k] * proximaCamada[k][i];
                    }

                    erros[i] = soma * funcao.Derivada2(camada[i].Saida);
                }
            }

            return erro / 2.0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entrada"></param>
        private void CalcularAtualizacoes(double[] entrada)
        {
            NeuronioAtivacao neuronio;


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void AtualizarRede()
        {
            throw new NotImplementedException();
        }
    }
}
