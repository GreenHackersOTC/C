namespace Areaofcircle
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
            this.btnCal = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(239, 201);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(103, 45);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(50, 73);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(59, 20);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "Radius";
            this.lblR.Click += new System.EventHandler(this.lblR_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(50, 118);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(43, 20);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Area";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(198, 76);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(78, 26);
            this.txtR.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(198, 130);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(82, 26);
            this.txtA.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 314);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnCal);
            this.Name = "frmMain";
            this.Text = "Area of circle";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtA;
    }
}

