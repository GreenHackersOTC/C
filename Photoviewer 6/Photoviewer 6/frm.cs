using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Photoviewer_6
{
    public partial class frmPhotoviewer : Form
    {
        public frmPhotoviewer()
        {
            InitializeComponent();
        }

  

        private void button_Click(object sender, EventArgs e)
        {

            if (picbox.Visible == true)
            {
                picbox.Visible = false;
                button.Text = "Show";
                textpassword.Show();
                textpassword.Clear();
                textpassword.Focus();
            }
            else
            {
                String password;
                password = textpassword.Text.ToString ();
                if (password == "Green Hackers")
                {
                    picbox.Visible = true;
                    button.Text = "Hide";
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    picbox.Visible = false;
                }
            }
        }

        private void picbox_Click(object sender, EventArgs e)
        {

        }
    }
}
