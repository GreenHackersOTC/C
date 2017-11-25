using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHello frmhello = new frmHello();
            frmhello.ShowDialog();
        }

        private void btnShowPhoto_Click(object sender, EventArgs e)
        {
            if (picPhoto.Visible == true)
            {
                picPhoto.Visible = false;
                btnShowPhoto.Text = "Show Photo";
            }
            else
            {
                picPhoto.Visible = true;
                btnShowPhoto.Text = "Hide Photo";
            }

        }

        private void btnHidePhoto_Click(object sender, EventArgs e)
        {
            picPhoto.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr=openFileDialog1.ShowDialog();
            if ( dr== DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr;
        //    openFileDialog1.Filter = "*.mp4|*.mp4";
        //    dr = openFileDialog1.ShowDialog();
        //    if (dr == DialogResult.OK)
        //    {               
        //        axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        //        axWindowsMediaPlayer1.Ctlcontrols.play();
        //    }
          
        }

      
     

      

}
