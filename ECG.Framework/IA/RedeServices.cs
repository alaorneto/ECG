using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework.IA
{
    public class RedeServices
    {
        private Rede _rede;
        public enum Tipo { Ativacao };

        public RedeServices();

        public void Setup(string descricao, Tipo tipo)
        {
            DatabaseEntities entities = new DatabaseEntities();
            REDE dbrede;

            var rede = from r in entities.REDE
                       where r.descricao == descricao
                       select r;

            dbrede = (REDE)rede;

            if (tipo == Tipo.Ativacao)
            {
                int entradas = dbrede.entradas;
                int[] neuronios = Utils.StringToInt(dbrede.neuronios);

                RedeAtivacao ativacao = new RedeAtivacao(new SigmoideFuncaoAtivacao(), entradas, neuronios);

                _rede = ativacao;
            }
        }

        public void Salvar(Rede rede, Tipo tipo)
        {

        }

        public Rede Rede
        {
            get { return this._rede; }
        }
    }
}
