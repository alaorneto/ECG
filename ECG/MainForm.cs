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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AtualizarInfo();
        }

        private void abrirExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ECGConfig.RedeQRS() == null) || (ECGConfig.RedeT() == null))
            {
                MessageBox.Show("Existem redes não configuradas!");
                return;
            }

            FECGAbrirExame dialog = new FECGAbrirExame();
            dialog.ShowDialog();
        }

        private void iniciarTreinamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FECGIniciarTreinamento dialog = new FECGIniciarTreinamento();
            dialog.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redeNeuronalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConfigRedeNeuronal dialog = new FConfigRedeNeuronal();
            dialog.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjudaSobre dialog = new FAjudaSobre();
            dialog.ShowDialog();
        }

        public void AtualizarInfo()
        {
            RedeAtivacao qrs = ECGConfig.RedeQRS();
            RedeAtivacao t = ECGConfig.RedeT();
            string qrsdesc = "-";
            string tdesc = "-";

            if (qrs != null)
                qrsdesc = qrs.Descricao;

            if (t != null)
                tdesc = t.Descricao;

            infoToolStripStatusLabel.Text = "[ Rede QRS selecionada: " + qrsdesc + " ]  [ Rede T selecionada: " + tdesc + " ]";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            AtualizarInfo();
        }
    }
}
