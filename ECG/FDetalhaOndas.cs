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
    public partial class FDetalhaOndas : Form
    {
        public FDetalhaOndas(double[] qrs1, double[] qrs2, double[] t1, double[] t2)
        {
            InitializeComponent();

            for (int i = 0; i < qrs1.Length; i++)
            {
                chartQRS1.Series[0].Points.Add(qrs1[i]);
            }

            for (int i = 0; i < qrs2.Length; i++)
            {
                chartQRS2.Series[0].Points.Add(qrs2[i]);
            }

            for (int i = 0; i < t1.Length; i++)
            {
                chartT1.Series[0].Points.Add(t1[i]);
            }

            for (int i = 0; i < qrs1.Length; i++)
            {
                chartT2.Series[0].Points.Add(t2[i]);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
