namespace Hello2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_forecast = new System.Windows.Forms.Label();
            this.picture_1 = new System.Windows.Forms.PictureBox();
            this.lbl_day_2 = new System.Windows.Forms.Label();
            this.lbl_des_2 = new System.Windows.Forms.Label();
            this.lbl_cond_2 = new System.Windows.Forms.Label();
            this.lbl_cond_3 = new System.Windows.Forms.Label();
            this.lbl_des_3 = new System.Windows.Forms.Label();
            this.lbl_day_3 = new System.Windows.Forms.Label();
            this.picture_2 = new System.Windows.Forms.PictureBox();
            this.lbl_wind_2 = new System.Windows.Forms.Label();
            this.lbl_temp_2 = new System.Windows.Forms.Label();
            this.lbl_temp_3 = new System.Windows.Forms.Label();
            this.lbl_wind_3 = new System.Windows.Forms.Label();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Red;
            this.lbl_cityName.Location = new System.Drawing.Point(45, 161);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(150, 69);
            this.lbl_cityName.TabIndex = 2;
            this.lbl_cityName.Text = "Nice";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.ForeColor = System.Drawing.Color.Green;
            this.lbl_country.Location = new System.Drawing.Point(48, 254);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(57, 46);
            this.lbl_country.TabIndex = 3;
            this.lbl_country.Text = "Fr";
            // 
            // picture_main
            // 
            this.picture_main.Image = ((System.Drawing.Image)(resources.GetObject("picture_main.Image")));
            this.picture_main.Location = new System.Drawing.Point(56, 420);
            this.picture_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(124, 125);
            this.picture_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_main.TabIndex = 4;
            this.picture_main.TabStop = false;
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_temp.Location = new System.Drawing.Point(199, 420);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(108, 102);
            this.lbl_temp.TabIndex = 5;
            this.lbl_temp.Text = "C";
            // 
            // lbl_forecast
            // 
            this.lbl_forecast.AutoSize = true;
            this.lbl_forecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forecast.ForeColor = System.Drawing.Color.Red;
            this.lbl_forecast.Location = new System.Drawing.Point(638, 115);
            this.lbl_forecast.Name = "lbl_forecast";
            this.lbl_forecast.Size = new System.Drawing.Size(176, 46);
            this.lbl_forecast.TabIndex = 6;
            this.lbl_forecast.Text = "Forecast";
            // 
            // picture_1
            // 
            this.picture_1.Image = ((System.Drawing.Image)(resources.GetObject("picture_1.Image")));
            this.picture_1.Location = new System.Drawing.Point(646, 188);
            this.picture_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_1.Name = "picture_1";
            this.picture_1.Size = new System.Drawing.Size(124, 125);
            this.picture_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_1.TabIndex = 7;
            this.picture_1.TabStop = false;
            // 
            // lbl_day_2
            // 
            this.lbl_day_2.AutoSize = true;
            this.lbl_day_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_day_2.Location = new System.Drawing.Point(791, 188);
            this.lbl_day_2.Name = "lbl_day_2";
            this.lbl_day_2.Size = new System.Drawing.Size(93, 38);
            this.lbl_day_2.TabIndex = 8;
            this.lbl_day_2.Text = "Days";
            // 
            // lbl_des_2
            // 
            this.lbl_des_2.AutoSize = true;
            this.lbl_des_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des_2.ForeColor = System.Drawing.Color.Teal;
            this.lbl_des_2.Location = new System.Drawing.Point(791, 242);
            this.lbl_des_2.Name = "lbl_des_2";
            this.lbl_des_2.Size = new System.Drawing.Size(158, 32);
            this.lbl_des_2.TabIndex = 10;
            this.lbl_des_2.Text = "Description";
            // 
            // lbl_cond_2
            // 
            this.lbl_cond_2.AutoSize = true;
            this.lbl_cond_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cond_2.ForeColor = System.Drawing.Color.Teal;
            this.lbl_cond_2.Location = new System.Drawing.Point(792, 290);
            this.lbl_cond_2.Name = "lbl_cond_2";
            this.lbl_cond_2.Size = new System.Drawing.Size(137, 32);
            this.lbl_cond_2.TabIndex = 11;
            this.lbl_cond_2.Text = "Condition";
            // 
            // lbl_cond_3
            // 
            this.lbl_cond_3.AutoSize = true;
            this.lbl_cond_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cond_3.ForeColor = System.Drawing.Color.Teal;
            this.lbl_cond_3.Location = new System.Drawing.Point(792, 479);
            this.lbl_cond_3.Name = "lbl_cond_3";
            this.lbl_cond_3.Size = new System.Drawing.Size(137, 32);
            this.lbl_cond_3.TabIndex = 15;
            this.lbl_cond_3.Text = "Condition";
            // 
            // lbl_des_3
            // 
            this.lbl_des_3.AutoSize = true;
            this.lbl_des_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des_3.ForeColor = System.Drawing.Color.Teal;
            this.lbl_des_3.Location = new System.Drawing.Point(791, 431);
            this.lbl_des_3.Name = "lbl_des_3";
            this.lbl_des_3.Size = new System.Drawing.Size(158, 32);
            this.lbl_des_3.TabIndex = 14;
            this.lbl_des_3.Text = "Description";
            // 
            // lbl_day_3
            // 
            this.lbl_day_3.AutoSize = true;
            this.lbl_day_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_3.ForeColor = System.Drawing.Color.Blue;
            this.lbl_day_3.Location = new System.Drawing.Point(791, 376);
            this.lbl_day_3.Name = "lbl_day_3";
            this.lbl_day_3.Size = new System.Drawing.Size(93, 38);
            this.lbl_day_3.TabIndex = 13;
            this.lbl_day_3.Text = "Days";
            // 
            // picture_2
            // 
            this.picture_2.Image = ((System.Drawing.Image)(resources.GetObject("picture_2.Image")));
            this.picture_2.Location = new System.Drawing.Point(646, 376);
            this.picture_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_2.Name = "picture_2";
            this.picture_2.Size = new System.Drawing.Size(124, 125);
            this.picture_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_2.TabIndex = 12;
            this.picture_2.TabStop = false;
            // 
            // lbl_wind_2
            // 
            this.lbl_wind_2.AutoSize = true;
            this.lbl_wind_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind_2.ForeColor = System.Drawing.Color.Teal;
            this.lbl_wind_2.Location = new System.Drawing.Point(1120, 290);
            this.lbl_wind_2.Name = "lbl_wind_2";
            this.lbl_wind_2.Size = new System.Drawing.Size(115, 32);
            this.lbl_wind_2.TabIndex = 16;
            this.lbl_wind_2.Text = "12 km/h";
            // 
            // lbl_temp_2
            // 
            this.lbl_temp_2.AutoSize = true;
            this.lbl_temp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_temp_2.Location = new System.Drawing.Point(1120, 242);
            this.lbl_temp_2.Name = "lbl_temp_2";
            this.lbl_temp_2.Size = new System.Drawing.Size(47, 32);
            this.lbl_temp_2.TabIndex = 17;
            this.lbl_temp_2.Text = "16";
            // 
            // lbl_temp_3
            // 
            this.lbl_temp_3.AutoSize = true;
            this.lbl_temp_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_temp_3.Location = new System.Drawing.Point(1120, 431);
            this.lbl_temp_3.Name = "lbl_temp_3";
            this.lbl_temp_3.Size = new System.Drawing.Size(47, 32);
            this.lbl_temp_3.TabIndex = 18;
            this.lbl_temp_3.Text = "16";
            // 
            // lbl_wind_3
            // 
            this.lbl_wind_3.AutoSize = true;
            this.lbl_wind_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind_3.ForeColor = System.Drawing.Color.Teal;
            this.lbl_wind_3.Location = new System.Drawing.Point(1120, 479);
            this.lbl_wind_3.Name = "lbl_wind_3";
            this.lbl_wind_3.Size = new System.Drawing.Size(115, 32);
            this.lbl_wind_3.TabIndex = 19;
            this.lbl_wind_3.Text = "12 km/h";
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(21, 28);
            this.txt_cityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(264, 26);
            this.txt_cityName.TabIndex = 22;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(303, 15);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 51);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(14, 744);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 51);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 810);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_cityName);
            this.Controls.Add(this.lbl_wind_3);
            this.Controls.Add(this.lbl_temp_3);
            this.Controls.Add(this.lbl_temp_2);
            this.Controls.Add(this.lbl_wind_2);
            this.Controls.Add(this.lbl_cond_3);
            this.Controls.Add(this.lbl_des_3);
            this.Controls.Add(this.lbl_day_3);
            this.Controls.Add(this.picture_2);
            this.Controls.Add(this.lbl_cond_2);
            this.Controls.Add(this.lbl_des_2);
            this.Controls.Add(this.lbl_day_2);
            this.Controls.Add(this.picture_1);
            this.Controls.Add(this.lbl_forecast);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.picture_main);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_cityName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Weather Application_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_forecast;
        private System.Windows.Forms.PictureBox picture_1;
        private System.Windows.Forms.Label lbl_day_2;
        private System.Windows.Forms.Label lbl_des_2;
        private System.Windows.Forms.Label lbl_cond_2;
        private System.Windows.Forms.Label lbl_cond_3;
        private System.Windows.Forms.Label lbl_des_3;
        private System.Windows.Forms.Label lbl_day_3;
        private System.Windows.Forms.PictureBox picture_2;
        private System.Windows.Forms.Label lbl_wind_2;
        private System.Windows.Forms.Label lbl_temp_2;
        private System.Windows.Forms.Label lbl_temp_3;
        private System.Windows.Forms.Label lbl_wind_3;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
    }
}

