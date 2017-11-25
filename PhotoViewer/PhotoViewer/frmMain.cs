using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picPhoto.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picPhoto.Visible = false;
        }
    }
}
