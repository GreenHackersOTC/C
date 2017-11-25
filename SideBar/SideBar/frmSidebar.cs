using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; //process
using System.IO; //stream

namespace SideBar
{
    public partial class frmSidebar : Form
    {      

        public frmSidebar()
        {
            path[0] = "mspaint";
            path[1] = @"C:\Program Files (x86)\Microsoft Office\Office15\WINWORD.EXE";
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string[] path = new string[10];
       
        private void btn1_Click(object sender, EventArgs e)
        {
            Process.Start(path[0]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Process.Start(path[1]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"path11.txt")) //working directory where this exe exist
                {
                    string line;
                    int i = 0;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        path[i++] = line;
                    }
                    btn1.BackgroundImage = Image.FromFile( path[0] + ".png");
                    btn2.BackgroundImage = Image.FromFile( path[1] + ".png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void frmSidebar_Load(object sender, EventArgs e)
        {
            
        }


    }
}
