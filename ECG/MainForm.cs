using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FECGAbrirExame dialog = new FECGAbrirExame();

            dialog.ShowDialog();
        }

        private void redeNeuronalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConfigRedeNeuronal fconf = new FConfigRedeNeuronal();
            fconf.ShowDialog();
        }
    }
}
