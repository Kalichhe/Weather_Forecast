namespace Weather_Forecast.Forms
{
    partial class Login
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
            this.Register_button2 = new System.Windows.Forms.Button();
            this.Send_button1 = new System.Windows.Forms.Button();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.Usertext_Box1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_button2
            // 
            this.Register_button2.Font = new System.Drawing.Font("Bell MT", 16F);
            this.Register_button2.Location = new System.Drawing.Point(169, 136);
            this.Register_button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_button2.Name = "Register_button2";
            this.Register_button2.Size = new System.Drawing.Size(100, 33);
            this.Register_button2.TabIndex = 4;
            this.Register_button2.Text = "Register";
            this.Register_button2.UseVisualStyleBackColor = true;
            this.Register_button2.Click += new System.EventHandler(this.Register_button2_Click);
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(66, 136);
            this.Send_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(82, 33);
            this.Send_button1.TabIndex = 3;
            this.Send_button1.Text = "Send";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox2.Location = new System.Drawing.Point(145, 93);
            this.Password_textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.PasswordChar = '*';
            this.Password_textBox2.Size = new System.Drawing.Size(194, 25);
            this.Password_textBox2.TabIndex = 2;
            // 
            // Usertext_Box1
            // 
            this.Usertext_Box1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertext_Box1.Location = new System.Drawing.Point(145, 56);
            this.Usertext_Box1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Usertext_Box1.Name = "Usertext_Box1";
            this.Usertext_Box1.Size = new System.Drawing.Size(194, 25);
            this.Usertext_Box1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // Login_label1
            // 
            this.Login_label1.AutoSize = true;
            this.Login_label1.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label1.Location = new System.Drawing.Point(128, 7);
            this.Login_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_label1.Name = "Login_label1";
            this.Login_label1.Size = new System.Drawing.Size(95, 38);
            this.Login_label1.TabIndex = 7;
            this.Login_label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 189);
            this.Controls.Add(this.Register_button2);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.Password_textBox2);
            this.Controls.Add(this.Usertext_Box1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_button2;
        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.TextBox Password_textBox2;
        private System.Windows.Forms.TextBox Usertext_Box1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Login_label1;
    }
}