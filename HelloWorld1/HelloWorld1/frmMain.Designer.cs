namespace HelloWorld1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fjileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnShowPhoto = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fjileToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fjileToolStripMenuItem
            // 
            this.fjileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fjileToolStripMenuItem.Name = "fjileToolStripMenuItem";
            this.fjileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fjileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(28, 56);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(64, 47);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 1;
            this.picPhoto.TabStop = false;
            // 
            // btnShowPhoto
            // 
            this.btnShowPhoto.Location = new System.Drawing.Point(924, 94);
            this.btnShowPhoto.Name = "btnShowPhoto";
            this.btnShowPhoto.Size = new System.Drawing.Size(145, 40);
            this.btnShowPhoto.TabIndex = 2;
            this.btnShowPhoto.Text = "Show Photo";
            this.btnShowPhoto.UseVisualStyleBackColor = true;
            this.btnShowPhoto.Click += new System.EventHandler(this.btnShowPhoto_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(927, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(141, 36);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Photo";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(826, 254);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 319);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(636, 8);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 50;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(39, 133);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(578, 145);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("http://www.greenhackeronline.com", System.UriKind.Absolute);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 350);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnShowPhoto);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fjileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnShowPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}