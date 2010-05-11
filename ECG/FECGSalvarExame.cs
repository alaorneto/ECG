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
        public FECGSalvarExame()
        {
            InitializeComponent();
        }

        private void FECGSalvarExame_Load(object sender, EventArgs e)
        {
            Patologias patologias = new Patologias();

            foreach(string p in patologias.patologiasQRS.Values)
                comboBoxQRS.Items.Add(p);

            foreach (string p in patologias.patologiasT.Values)
                comboBoxT.Items.Add(p);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
