namespace HelloWorld1
{
    partial class frmHello
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
            this.lblHello = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(341, 37);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 68);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Area";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(41, 37);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(59, 20);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(145, 36);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(166, 26);
            this.txtRadius.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(145, 79);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(166, 26);
            this.txtArea.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area";
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 127);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmHello";
            this.Text = "Programmer: Aung Win Htut";
            this.Load += new System.EventHandler(this.frmHello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
    }
}

