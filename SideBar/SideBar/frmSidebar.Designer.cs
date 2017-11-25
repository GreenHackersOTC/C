namespace SideBar
{
    partial class frmSidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSidebar));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(16, 10);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 74);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Location = new System.Drawing.Point(120, 10);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 73);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(859, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 73);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(238, 10);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(87, 72);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Settings";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // frmSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 93);
            this.ControlBox = false;
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmSidebar";
            this.Text = "Side Bar by Green Hackers";
            this.Load += new System.EventHandler(this.frmSidebar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn3;
    }
}

