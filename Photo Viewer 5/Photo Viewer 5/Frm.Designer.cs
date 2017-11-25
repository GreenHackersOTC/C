namespace Photo_Viewer_5
{
    partial class Frm
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
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.btnshowhide = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox
            // 
            this.Picbox.Image = global::Photo_Viewer_5.Properties.Resources._23415603_783490658521074_8818496790080581955_o;
            this.Picbox.Location = new System.Drawing.Point(44, 13);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(543, 495);
            this.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            this.Picbox.Click += new System.EventHandler(this.Picbox_Click);
            // 
            // btnshowhide
            // 
            this.btnshowhide.Location = new System.Drawing.Point(646, 140);
            this.btnshowhide.Name = "btnshowhide";
            this.btnshowhide.Size = new System.Drawing.Size(127, 42);
            this.btnshowhide.TabIndex = 1;
            this.btnshowhide.Text = "Show";
            this.btnshowhide.UseVisualStyleBackColor = true;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(661, 64);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 26);
            this.textpassword.TabIndex = 2;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 537);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.btnshowhide);
            this.Controls.Add(this.Picbox);
            this.Name = "Frm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.Button btnshowhide;
        private System.Windows.Forms.TextBox textpassword;
    }
}

