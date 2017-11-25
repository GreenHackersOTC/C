using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Areaofcircle
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblR_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                double a, r;
                r = double.Parse(txtR.Text.ToString());
                a = 3.14 * r * r;
                txtA.Text = a.ToString();
                txtR.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
