using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello2
{
    public partial class frmHello2 : Form
    {
        public frmHello2()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Form1 frmh1 = new Form1();
            frmh1.Show();
        }
    }
}
