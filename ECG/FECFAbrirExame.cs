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
    public partial class FECFAbrirExame : Form
    {
        public FECFAbrirExame()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            //openFileDialog.Filter;
            openFileDialog.ShowDialog();
        }
    }
}
