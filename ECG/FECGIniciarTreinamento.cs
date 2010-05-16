using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECG.Framework;
using ECG.Framework.IA;

namespace ECG
{
    public partial class FECGIniciarTreinamento : Form
    {
        public FECGIniciarTreinamento()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FECGIniciarTreinamento_Load(object sender, EventArgs e)
        {
            comboBoxOnda.SelectedItem = "Complexo QRS";
        }

        private void buttonTreinar_Click(object sender, EventArgs e)
        {
            if (comboBoxOnda.SelectedItem == "Complexo QRS")
                TreinarQRS();
            if (comboBoxOnda.SelectedItem == "Onda T")
                TreinarT();

            


        }

        private void TreinarQRS()
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<ComplexoQRS> qrslist = new List<ComplexoQRS>();

            var query = from q in entities.QRS
                        select q;

            foreach (QRS qrs in query)
            {
                qrslist.Add(new ComplexoQRS(qrs));
            }

            AprendizadoBackPropagation abp = new AprendizadoBackPropagation(ECGConfig.RedeQRS());

            foreach (ComplexoQRS qrs in qrslist)
            {
                double erro = abp.Executar(qrs.Vetor, qrs.Diagnostico);
            }
           
        }

        private void TreinarT()
        {
        }
    }
}
