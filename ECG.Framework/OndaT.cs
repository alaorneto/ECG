using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG.Framework
{
    public class OndaT
    {
        public OndaT(double[] valores)
        {
            Length = valores.Length;
            Vetor = valores;
        }

        public OndaT(long id)
        {

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
