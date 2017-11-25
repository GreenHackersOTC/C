namespace PhotoViewer
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
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(10, 13);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(532, 314);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(561, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 37);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(561, 73);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(123, 33);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide Image";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 338);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.picPhoto);
            this.Name = "frmMain";
            this.Text = "Photo Viewer 2017";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;

    }
}

