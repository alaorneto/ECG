using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class OndaT
    {
        public OndaT()
        { }

        public OndaT(double[] valores)
        {
            Length = valores.Length;
            Vetor = valores;
        }

        public OndaT(long id)
        {
            DatabaseEntities entities = new DatabaseEntities();
            OndaT dbonda = new OndaT();

            var o = from onda in entities.T
                    where onda.id == id
                    select onda;
            
            dbonda = (OndaT)o;
            
            if (o == null)
                throw new Exception("Onda não encontrada");

            this.Id = dbonda.Id;
            this.Vetor = dbonda.Vetor;
            this.Length = dbonda.Length;
            this.Diagnostico = dbonda.Diagnostico;
        }

        public long Id
        {
            get;
            set;
        }

        public ONDA Onda
        {
            get;
            set;
        }

        public int Length
        {
            get;
            set;
        }

        public double[] Vetor
        {
            get;
            set;
        }

        public string Diagnostico
        {
            get;
            set;
        }

        public void Salvar()
        {
            DatabaseEntities entities = new DatabaseEntities();
            OndaT ondat = this;
            T t = new T();

            string vetor = "";

            foreach (double d in ondat.Vetor)
            {
                vetor += d + ";";
            }

            t.vetor = vetor;
            t.length = ondat.Length;

            entities.AddToT(t);

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
