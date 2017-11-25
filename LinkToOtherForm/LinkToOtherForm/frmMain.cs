using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkToOtherForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
