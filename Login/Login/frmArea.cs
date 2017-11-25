using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double R;
            R = double.Parse(txtRa.Text.ToString());
            double A;
            A = 3.14 * R * R;
            txtArea.Text = A.ToString();
            
        }
    }
}
