using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ECG;
using ECG.Framework;

namespace ECG.Framework
{
    public class Onda
    {
        OndaHelper helper;

        public Onda()
        { }

        public Onda(Bitmap imagem)
        {
            ComplexosQRS = null;
            OndasT = null;

            helper = new OndaHelper(imagem);

            Vetor = helper.GerarVetor();

            Length = Vetor.Length;

            ComplexosQRS = helper.ComplexosQRS();
            //OndasT = helper.OndasT();
        }

        public Onda(long id)
        {

        }

        public long Id
        {
            get;
            set;
        }

        public double[] Vetor
        {
            get;
            set;
        }

        public int Length
        {
            get;
            set;
        }

        public ComplexoQRS[] ComplexosQRS
        {
            get;
            set;
        }

        public OndaT[] OndasT
        {
            get;
            set;
        }

        public void Salvar()
        {
            DatabaseEntities entities = new DatabaseEntities();
            Onda onda = this;
            ONDA o = new ONDA();

            string vetor = "";

            foreach(double d in onda.Vetor)
            {
                vetor += d + ";";
            }

            o.vetor = vetor;
            o.length = onda.Length;

            entities.AddToONDA(o);

            try
            {
                entities.SaveChanges();

                Console.WriteLine("Onda inserida com o id {0}", o.id);
                
                foreach (ComplexoQRS qrs in onda.ComplexosQRS)
                {
                    qrs.Onda = o;
                    qrs.Salvar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                throw (ex);
            }
        }
    }
}
