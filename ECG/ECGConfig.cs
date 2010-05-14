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
        public RedeAtivacao RedeQRS
        {
            get
            {
                DatabaseEntities entities = new DatabaseEntities();
                RedeServices services = new RedeServices();

                var query = from q in entities.CONFIG
                            where q.descr == "QRS"
                            select q;

                string descr = query.FirstOrDefault().ToString();

                return services.Setup(descr, RedeServices.Tipo.Ativacao);
            }
        }

        public RedeAtivacao RedeT
        {
            get
            {
                DatabaseEntities entities = new DatabaseEntities();
                RedeServices services = new RedeServices();

                var query = from q in entities.CONFIG
                            where q.descr == "T"
                            select q;

                string descr = query.FirstOrDefault().ToString();

                return services.Setup(descr, RedeServices.Tipo.Ativacao);
            }
        }

    }
}
