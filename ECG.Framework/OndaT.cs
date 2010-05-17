using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class OndaT
    {
        const int TSize = 30;
        double[] vetor = new double[TSize];

        public OndaT(double[] valores)
        {
            Vetor = valores;
        }

        public OndaT(T t)
        {
            this.Id = t.id;
            this.Vetor = Utils.StringToDouble(t.vetor);
            this.Diagnostico = Utils.StringToDouble(t.diag);
        }

        public long Id
        {
            get;
            set;
        }

        public long Onda
        {
            get;
            set;
        }

        public int Length
        {
            get { 
                return TSize; 
            }
        }

        public double[] Vetor
        {
            get
            {
                return this.vetor;
            }
            set
            {
                int count = 0;
                int sobra = (int)((TSize - value.Length) / 2);

                for (int i = 0; i < sobra; i++)
                {
                    vetor[count++] = 0;
                }

                for (int j = 0; j < value.Length; j++)
                {
                    vetor[count++] = value[j];
                }

                for (int k = sobra + value.Length; k < TSize; k++)
                {
                    vetor[count++] = 0;
                }
            }
        }

        public double[] Diagnostico
        {
            get;
            set;
        }

        public void Salvar(long ondaId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            OndaT ondat = this;
            T t;

            var query = from f in entities.T
                        where f.id == ondat.Id
                        select f;

            if (query.Count(q => q.id == ondat.Id) != 0)
            {
                t = query.FirstOrDefault<T>();
            }
            else
            {
                t = new T();
                entities.AddToT(t);
            }

            string vetor = "";

            foreach (double d in ondat.Vetor)
            {
                vetor += d + ";";
            }

            t.onda = ondaId;
            t.vetor = vetor;
            t.length = ondat.Length;
            t.diag = Utils.DoubleToString(ondat.Diagnostico);

            try
            {
                entities.SaveChanges();

                Console.WriteLine("Onda T inserida com o id {0}", t.id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw (ex);
            }
        }
    }
}
