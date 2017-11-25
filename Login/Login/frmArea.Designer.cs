namespace Login
{
    partial class frmArea
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
            this.btncal = new System.Windows.Forms.Button();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(246, 262);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(159, 52);
            this.btncal.TabIndex = 1;
            this.btncal.Text = "calculate";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(246, 102);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(180, 26);
            this.txtRa.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(246, 173);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(180, 26);
            this.txtArea.TabIndex = 3;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(118, 106);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(59, 20);
            this.lblRa.TabIndex = 4;
            this.lblRa.Text = "Radius";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(120, 178);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.btncal);
            this.Name = "frmArea";
            this.Text = "Finding Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblArea;
    }
}

