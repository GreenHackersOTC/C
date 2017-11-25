using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Photo_viewer_4
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (picbox.Visible == true)
            {
                picbox.Visible = false;
                btn.Text = "Show";
                txtpassword.Visible = true;
                txtpassword.Text = "";
                txtpassword.Clear();
                txtpassword.Focus();
            }
            else
            {
                string password;
                password = txtpassword.Text.ToString();
                if (password == "Green")
                {
                    picbox.Visible = true;
                    btn.Text = "Hide";
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }

                
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }
    }
}
