﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ECG.Framework
{
    public class ComplexoQRS
    {
        const int QRSSize = 50;
        double[] vetor = new double[QRSSize];

        public ComplexoQRS(double[] valores)
        {
            Vetor = valores;
        }

        public ComplexoQRS(QRS qrs)
        {
            this.Id = qrs.id;
            this.Vetor = Utils.StringToDouble(qrs.vetor);
            this.Diagnostico = Utils.StringToDouble(qrs.diag);
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
            get
            {
                return QRSSize;
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

        public double[] Diagnostico
        {
            get;
            set;
        }

        public void Salvar()
        {
            DatabaseEntities entities = new DatabaseEntities();
            ComplexoQRS qrs = this;
            QRS q;

            if (qrs.Id != null)
            {
                var query = from f in entities.QRS
                            where f.id == qrs.Id
                            select f;

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

            q.vetor = vetor;
            q.length = qrs.Length;

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
