namespace Weather_Forecast.Forms
{
    partial class Predict
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Latitude_textBox1 = new System.Windows.Forms.TextBox();
            this.Length_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Predict_button1 = new System.Windows.Forms.Button();
            this.Maximum_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Minimum_checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindSpeed_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Sunset_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Sunrise_checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predict";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitude:";
            // 
            // Latitude_textBox1
            // 
            this.Latitude_textBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latitude_textBox1.Location = new System.Drawing.Point(109, 41);
            this.Latitude_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.Latitude_textBox1.Name = "Latitude_textBox1";
            this.Latitude_textBox1.Size = new System.Drawing.Size(163, 25);
            this.Latitude_textBox1.TabIndex = 1;
            // 
            // Length_textBox1
            // 
            this.Length_textBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length_textBox1.Location = new System.Drawing.Point(364, 43);
            this.Length_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.Length_textBox1.Name = "Length_textBox1";
            this.Length_textBox1.Size = new System.Drawing.Size(163, 25);
            this.Length_textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Daily weather variables";
            // 
            // Predict_button1
            // 
            this.Predict_button1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predict_button1.Location = new System.Drawing.Point(95, 139);
            this.Predict_button1.Name = "Predict_button1";
            this.Predict_button1.Size = new System.Drawing.Size(95, 30);
            this.Predict_button1.TabIndex = 8;
            this.Predict_button1.Text = "Predict";
            this.Predict_button1.UseVisualStyleBackColor = true;
            this.Predict_button1.Click += new System.EventHandler(this.Predict_button1_Click);
            // 
            // Maximum_checkBox1
            // 
            this.Maximum_checkBox1.AutoSize = true;
            this.Maximum_checkBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximum_checkBox1.Location = new System.Drawing.Point(3, 3);
            this.Maximum_checkBox1.Name = "Maximum_checkBox1";
            this.Maximum_checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Maximum_checkBox1.Size = new System.Drawing.Size(266, 26);
            this.Maximum_checkBox1.TabIndex = 3;
            this.Maximum_checkBox1.Text = "Maximum Temperature (2 m)";
            this.Maximum_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Minimum_checkBox1
            // 
            this.Minimum_checkBox1.AutoSize = true;
            this.Minimum_checkBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimum_checkBox1.Location = new System.Drawing.Point(3, 35);
            this.Minimum_checkBox1.Name = "Minimum_checkBox1";
            this.Minimum_checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Minimum_checkBox1.Size = new System.Drawing.Size(263, 26);
            this.Minimum_checkBox1.TabIndex = 4;
            this.Minimum_checkBox1.Text = "Minimum Temperature (2 m)";
            this.Minimum_checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.WindSpeed_checkBox1);
            this.panel1.Controls.Add(this.Sunset_checkBox1);
            this.panel1.Controls.Add(this.Sunrise_checkBox1);
            this.panel1.Controls.Add(this.Maximum_checkBox1);
            this.panel1.Controls.Add(this.Minimum_checkBox1);
            this.panel1.Location = new System.Drawing.Point(245, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 160);
            this.panel1.TabIndex = 19;
            // 
            // WindSpeed_checkBox1
            // 
            this.WindSpeed_checkBox1.AutoSize = true;
            this.WindSpeed_checkBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed_checkBox1.Location = new System.Drawing.Point(3, 67);
            this.WindSpeed_checkBox1.Name = "WindSpeed_checkBox1";
            this.WindSpeed_checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindSpeed_checkBox1.Size = new System.Drawing.Size(268, 26);
            this.WindSpeed_checkBox1.TabIndex = 5;
            this.WindSpeed_checkBox1.Text = "Maximum Wind Speed (10 m)";
            this.WindSpeed_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Sunset_checkBox1
            // 
            this.Sunset_checkBox1.AutoSize = true;
            this.Sunset_checkBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset_checkBox1.Location = new System.Drawing.Point(3, 131);
            this.Sunset_checkBox1.Name = "Sunset_checkBox1";
            this.Sunset_checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sunset_checkBox1.Size = new System.Drawing.Size(82, 26);
            this.Sunset_checkBox1.TabIndex = 7;
            this.Sunset_checkBox1.Text = "Sunset";
            this.Sunset_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Sunrise_checkBox1
            // 
            this.Sunrise_checkBox1.AutoSize = true;
            this.Sunrise_checkBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise_checkBox1.Location = new System.Drawing.Point(3, 99);
            this.Sunrise_checkBox1.Name = "Sunrise_checkBox1";
            this.Sunrise_checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sunrise_checkBox1.Size = new System.Drawing.Size(88, 26);
            this.Sunrise_checkBox1.TabIndex = 6;
            this.Sunrise_checkBox1.Text = "Sunrise";
            this.Sunrise_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Predict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Predict_button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Length_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Latitude_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Predict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predict";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Latitude_textBox1;
        private System.Windows.Forms.TextBox Length_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Predict_button1;
        private System.Windows.Forms.CheckBox Maximum_checkBox1;
        private System.Windows.Forms.CheckBox Minimum_checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Sunset_checkBox1;
        private System.Windows.Forms.CheckBox Sunrise_checkBox1;
        private System.Windows.Forms.CheckBox WindSpeed_checkBox1;
    }
}