using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Framework
{
    public class ComplexoQRS
    {
        const int QRSSize = 60;
        double[] vetor = new double[QRSSize];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valores"></param>
        public ComplexoQRS(double[] valores)
        {
            Vetor = valores;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qrs"></param>
        public ComplexoQRS(QRS qrs)
        {
            this.Id = qrs.id;
            this.Vetor = Utils.StringToDouble(qrs.vetor);
            this.Diagnostico = Utils.StringToDouble(qrs.diag);
        }

        /// <summary>
        /// 
        /// </summary>
        public long Id
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public long Onda
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Length
        {
            get
            {
                return QRSSize;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] Vetor
        {
            get
            {
                return this.vetor;
            }
            set
            {
                int count = 0;
                int sobra = (int)((QRSSize - value.Length)/2);

                for (int i = 0; i < sobra; i++)
                {
                    vetor[count++] = 0;
                }

                for (int j = 0; j < value.Length; j++)
                {
                    vetor[count++] = value[j];
                }

                for (int k = sobra + value.Length; k < QRSSize; k++)
                {
                    vetor[count++] = 0;
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] Diagnostico
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ondaId"></param>
        public void Salvar(long ondaId)
        {
            DatabaseEntities entities = new DatabaseEntities();
            ComplexoQRS qrs = this;
            QRS q;

            var query = from f in entities.QRS
                            where f.id == qrs.Id
                            select f;

            if (query.Count(t => t.id == qrs.Id) != 0)
            {
                q = query.FirstOrDefault<QRS>();
            }
            else
            {
                q = new QRS();
                entities.AddToQRS(q);
            }

            string vetor = "";

            foreach (double d in qrs.Vetor)
            {
                vetor += d + ";";
            }

            q.onda = ondaId;
            q.vetor = vetor;
            q.length = qrs.Length;
            q.diag = Utils.DoubleToString(qrs.Diagnostico);

            try
            {
                entities.SaveChanges();

                Console.WriteLine("Complexo QRS inserido/atualizado com o id {0}", q.id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw (ex);
            }
        }
    }
}
