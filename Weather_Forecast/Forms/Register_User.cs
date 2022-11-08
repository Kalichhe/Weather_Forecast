using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_Forecast.DataBase.User;
using Weather_Forecast.Encrypt_Decrypt;

namespace Weather_Forecast.Forms
{
    public partial class Register_User : Form
    {
        public Register_User()
        {
            InitializeComponent();
        }
        
        
        private void Send_button1_Click(object sender, EventArgs e)
        {

            if (Username_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A USERNAME");
            }
            else if(Name_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A NAME");
            }else if(Email_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A EMAIL");
            }else if(Password_textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A PASSWORD");
            }else if(ConfirmPassword_textBox3.Text.Trim() == "")
            {
                MessageBox.Show("CONFIRM THE PASSWORD");
            }
            else
            {   
                try 
                { 
                    User user = new User();
                    user.Username = Username_textBox1.Text.Trim();
                    user.Name = Name_textBox1.Text.Trim();
                    user.Email = Email_textBox1.Text.Trim();
                    user.Password = Encrypt._Encrypt(Password_textBox2.Text.Trim());
                    user.Confirm_password = Encrypt._Encrypt(ConfirmPassword_textBox3.Text.Trim());
                    if (user.Password != user.Confirm_password)
                    {
                        MessageBox.Show("THE PASSWORD IS NOT THE SAME, CHECK IT");
                    }
                    else if (User_DB.userExist(Username_textBox1.Text.Trim()))
                    {
                        if (User_DB.Save(user))
                        {
                            Clean_Fields();
                            MessageBox.Show("USER ADDED SUCCESSFULLY");
                        }
                        else
                        {
                            MessageBox.Show("PASSWORD ERROR TOO LONG, MAXIMUM 18 CHARACTERS");

                        }
                    }
                    else
                    {
                        MessageBox.Show("A USER WITH THE SAME NAME ALREADY EXISTS");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Clean_Fields()
        {
            Username_textBox1.Text = "";
            Name_textBox1.Text = "";
            Email_textBox1.Text = "";
            Password_textBox2.Text = "";
            ConfirmPassword_textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
