namespace ArrayCS
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(261, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 72);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Area";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(126, 17);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(109, 26);
            this.txtR.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(126, 53);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(108, 26);
            this.txtA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Area(sq cm)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmMain";
            this.Text = "Array Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

