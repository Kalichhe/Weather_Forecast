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
            this.Category_listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predict";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitude:";
            // 
            // Latitude_textBox1
            // 
            this.Latitude_textBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latitude_textBox1.Location = new System.Drawing.Point(145, 50);
            this.Latitude_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Latitude_textBox1.Name = "Latitude_textBox1";
            this.Latitude_textBox1.Size = new System.Drawing.Size(216, 30);
            this.Latitude_textBox1.TabIndex = 1;
            // 
            // Length_textBox1
            // 
            this.Length_textBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length_textBox1.Location = new System.Drawing.Point(485, 53);
            this.Length_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Length_textBox1.Name = "Length_textBox1";
            this.Length_textBox1.Size = new System.Drawing.Size(216, 30);
            this.Length_textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Daily weather variables";
            // 
            // Predict_button1
            // 
            this.Predict_button1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predict_button1.Location = new System.Drawing.Point(955, 47);
            this.Predict_button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Predict_button1.Name = "Predict_button1";
            this.Predict_button1.Size = new System.Drawing.Size(96, 37);
            this.Predict_button1.TabIndex = 16;
            this.Predict_button1.Text = "Send";
            this.Predict_button1.UseVisualStyleBackColor = true;
            this.Predict_button1.Click += new System.EventHandler(this.Predict_button1_Click);
            // 
            // Category_listBox1
            // 
            this.Category_listBox1.FormattingEnabled = true;
            this.Category_listBox1.ItemHeight = 16;
            this.Category_listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Category_listBox1.Location = new System.Drawing.Point(327, 90);
            this.Category_listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Category_listBox1.Name = "Category_listBox1";
            this.Category_listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Category_listBox1.Size = new System.Drawing.Size(179, 100);
            this.Category_listBox1.TabIndex = 17;
            // 
            // Predict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Category_listBox1);
            this.Controls.Add(this.Predict_button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Length_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Latitude_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Predict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predict";
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
        private System.Windows.Forms.ListBox Category_listBox1;
    }
}