using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld1
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double r, a;
            if (txtRadius.Text != "")
            {
                r = double.Parse(txtRadius.Text);
                a = 3.14 * r * r;
                txtArea.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("please enter r value ");
                txtRadius.Focus();
            }
        }

        private void frmHello_Load(object sender, EventArgs e)
        {

        }

    

     
    }
}
