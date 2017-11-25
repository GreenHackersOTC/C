namespace LinkToOtherForm
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
            this.btnWeather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(90, 53);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(255, 52);
            this.btnWeather.TabIndex = 0;
            this.btnWeather.Text = "Show Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 243);
            this.Controls.Add(this.btnWeather);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeather;
    }
}

