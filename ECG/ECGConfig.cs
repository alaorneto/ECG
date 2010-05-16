using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECG.Framework;
using ECG.Framework.IA;

namespace ECG
{
    public static class ECGConfig
    {
        public static RedeAtivacao RedeQRS()
        {
            DatabaseEntities entities = new DatabaseEntities();
            RedeServices services = new RedeServices();

            var query = from q in entities.CONFIG
                        where q.onda == "QRS"
                        select q;

            if (entities.CONFIG.Count(q => q.onda == "QRS") == 0)
                return null;

            CONFIG conf = (CONFIG)query.First();

            string descr = conf.descr;

            RedeAtivacao a = services.Setup(descr, RedeServices.Tipo.Ativacao);

            return a;
        }

        public static RedeAtivacao RedeT()
        {
            DatabaseEntities entities = new DatabaseEntities();
            RedeServices services = new RedeServices();

            var query = from q in entities.CONFIG
                        where q.onda == "T"
                        select q;

            if (entities.CONFIG.Count(q => q.onda == "T") == 0)
                return null;

            CONFIG conf = (CONFIG)query.First();

            string descr = conf.descr;

            return services.Setup(descr, RedeServices.Tipo.Ativacao);
        }
    }
}
