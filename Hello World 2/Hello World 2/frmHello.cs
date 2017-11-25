using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello_World_2
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void frmHello_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

    
    }
}
