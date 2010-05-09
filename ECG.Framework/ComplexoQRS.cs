using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Framework
{
    public class ComplexoQRS
    {
        public ComplexoQRS(double[] valores)
        {
            Length = valores.Length;
            Vetor = valores;
        }

        public ComplexoQRS(long id)
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
            ComplexoQRS qrs = this;
            QRS q = new QRS();

            string vetor = "";

            foreach (double d in qrs.Vetor)
            {
                vetor += d + ";";
            }

            q.vetor = vetor;
            q.length = qrs.Length;

            entities.AddToQRS(q);

            try
            {
                entities.SaveChanges();

                Console.WriteLine("Complexo QRS inserido com o id {0}", q.id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw (ex);
            }
        }
    }
}
