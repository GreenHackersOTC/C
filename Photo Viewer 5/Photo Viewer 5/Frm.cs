using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Photo_Viewer_5
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Picbox_Click(object sender, EventArgs e)
        {
            if (Picbox.Visible == true)
            {
                Picbox.Visible = false;
                btnshowhide.Text = "Show";
            }
            else
            {
                Picbox.Visible = true;
                btnshowhide.Text = "Hide";
            }
        }
    }
}
