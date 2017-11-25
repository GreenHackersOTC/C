namespace Hello2
{
    partial class frmHello2
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
            this.btnCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(82, 40);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(298, 108);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "call Hello1";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // frmHello2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 314);
            this.Controls.Add(this.btnCall);
            this.Name = "frmHello2";
            this.Text = "Hello2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
    }
}

