using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    public class RedeServices
    {
        public enum Tipo { Ativacao };

        public RedeServices() { }

        public RedeAtivacao Setup(string descricao, Tipo tipo)
        {
            DatabaseEntities entities = new DatabaseEntities();
            RedeAtivacao ativacao;
            REDE fromdb;

            var query = from r in entities.REDE
                       where r.descricao == descricao
                       select r;

            if (entities.REDE.Count(r => r.descricao == descricao) == 0)
                return null;

            fromdb = (REDE)query.First();

            int entradas = fromdb.entradas;
            int[] neuronios = Utils.StringToInt(fromdb.neuronios);

            ativacao = new RedeAtivacao(new SigmoideFuncaoAtivacao(), entradas, neuronios);

            ativacao = Utils.SetupPesos(ativacao, fromdb.pesos);
            ativacao.Descricao = descricao;

            return ativacao;
        }

        public void Salvar(Rede rede, Tipo tipo, string onda)
        {
            DatabaseEntities entities = new DatabaseEntities();
            REDE fromdb;

            var query = from r in entities.REDE
                       where r.descricao == rede.Descricao
                       select r;

            if (entities.REDE.Count(r => r.descricao == rede.Descricao) == 0)
            {
                fromdb = new REDE();
                entities.AddToREDE(fromdb);
            }
            else
            {
                fromdb = (REDE)query.First();
            }

            fromdb.onda = onda;
            fromdb.camadas = rede.NumeroCamadas;
            fromdb.entradas = rede.NumeroEntradas;
            fromdb.neuronios = Utils.NeuroniosToString(rede);
            fromdb.pesos = Utils.PesosParaString((RedeAtivacao)rede);
            fromdb.descricao = rede.Descricao;

            entities.SaveChanges();
        }

    }
}
