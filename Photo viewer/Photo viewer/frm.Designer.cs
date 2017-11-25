namespace Photo_viewer
{
    partial class frmPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhoto));
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picphoto
            // 
            this.picphoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picphoto.BackgroundImage")));
            this.picphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picphoto.Image = global::Photo_viewer.Properties.Resources._23415603_783490658521074_8818496790080581955_o;
            this.picphoto.Location = new System.Drawing.Point(62, 44);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(473, 370);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picphoto.TabIndex = 0;
            this.picphoto.TabStop = false;
            this.picphoto.Visible = false;
            this.picphoto.Click += new System.EventHandler(this.picphoto_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(605, 123);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 50);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(605, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(118, 26);
            this.txtPassword.TabIndex = 0;
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 453);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.picphoto);
            this.Name = "frmPhoto";
            this.Text = "Photo viewer 2017";
            this.Load += new System.EventHandler(this.frmPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

