﻿using System;
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

        public Onda(Bitmap imagem)
        {
            ComplexosQRS = null;
            OndasT = null;

            helper = new OndaHelper(imagem);

            //helper.ExbibirParaConsole();

            Vetor = helper.GerarVetor();

            Length = Vetor.Length;

            ComplexosQRS = helper.ComplexosQRS();

            PicosQRS = helper.PicosQRS();
            OndasT = helper.OndasT();
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

        public int[] PicosQRS
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

                this.Id = o.id;

                Console.WriteLine("Onda inserida com o id {0}", o.id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                throw (ex);
            }
        }
    }
}
