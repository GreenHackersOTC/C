namespace Photoviewer_6
{
    partial class frmPhotoviewer
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
            this.picbox = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Image = global::Photoviewer_6.Properties.Resources._23415603_783490658521074_8818496790080581955_o;
            this.picbox.Location = new System.Drawing.Point(0, 28);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(573, 403);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(645, 127);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(153, 66);
            this.button.TabIndex = 1;
            this.button.Text = "Show";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(645, 56);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(163, 26);
            this.textpassword.TabIndex = 2;
            // 
            // frmPhotoviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 489);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.button);
            this.Controls.Add(this.picbox);
            this.Name = "frmPhotoviewer";
            this.Text = "Windows Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textpassword;
    }
}

