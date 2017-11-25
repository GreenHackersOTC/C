using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrayCS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double r, a;
            try
            {
                r = double.Parse(txtR.Text.ToString());
                a = 3.14 * r * r;
                txtA.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


    }
}
