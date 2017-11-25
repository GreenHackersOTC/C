namespace Photo_viewer_4
{
    partial class frm
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
            this.btn = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Image = global::Photo_viewer_4.Properties.Resources._23415603_783490658521074_8818496790080581955_o;
            this.picbox.Location = new System.Drawing.Point(40, 39);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(599, 429);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(701, 131);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(128, 56);
            this.btn.TabIndex = 1;
            this.btn.Text = "Hide";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(694, 59);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(149, 26);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.TabStop = false;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 522);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.picbox);
            this.Name = "frm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtpassword;
    }
}

