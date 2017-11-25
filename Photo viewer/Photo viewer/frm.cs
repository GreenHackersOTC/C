using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Photo_viewer
{
    public partial class frmPhoto : Form
    {
        public frmPhoto()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (picphoto.Visible == true)
            {
                picphoto.Visible = false;
                btnShow.Text = "Show";
                txtPassword.Visible = true;
                txtPassword.Text = "";
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                string password;
                password = txtPassword.Text.ToString();
                if (password == "aung")
                {
                    picphoto.Visible = true;
                    btnShow.Text = "Hide";
                    txtPassword.Visible = false;
                }
                else
                {
                    MessageBox.Show("wrong password. try again ");
                }
            }
          
        }

    

        private void picphoto_Click(object sender, EventArgs e)
        {

        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
