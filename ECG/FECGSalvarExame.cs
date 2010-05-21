using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECG.Framework;

namespace ECG
{
    public partial class FECGSalvarExame : Form
    {
        Patologias patologias = new Patologias();
        Onda onda;
        double[] patQRS;
        double[] patT;

        public FECGSalvarExame(Onda onda, double[] patQRS, double[] patT)
        {
            this.onda = onda;
            this.patQRS = patQRS;
            this.patT = patT;

            InitializeComponent();
        }

        private void FECGSalvarExame_Load(object sender, EventArgs e)
        {
            foreach(string p in patologias.patologiasQRS.Values)
                comboBoxQRS.Items.Add(p);

            foreach (string p in patologias.patologiasT.Values)
                comboBoxT.Items.Add(p);

            textBoxQRS.Text = patologias.EncontrarNomePorSaida(patQRS, "QRS");
            textBoxT.Text = patologias.EncontrarNomePorSaida(patT, "T");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                onda.Salvar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            foreach (ComplexoQRS qrs in onda.ComplexosQRS)
            {
                qrs.Diagnostico = patologias.EncontrarSaidaPorNome(comboBoxQRS.SelectedItem.ToString(), "QRS");
                qrs.Salvar(onda.Id);
            }

            foreach (OndaT t in onda.OndasT)
            {
                t.Diagnostico = patologias.EncontrarSaidaPorNome(comboBoxT.SelectedItem.ToString(), "T");
                t.Salvar(onda.Id);
            }

            MessageBox.Show("Onda salva com sucesso!");

            this.Close();
        }
    }
}
