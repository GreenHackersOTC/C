using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeatherApplication_2010
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
