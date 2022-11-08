using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_Forecast.DataBase.Connection_DB;
using Weather_Forecast.DataBase.User;
using Weather_Forecast.Encrypt_Decrypt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Weather_Forecast.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Register_button2_Click(object sender, EventArgs e)
        {
            using (Register_User register_User = new Register_User())
                register_User.ShowDialog();
        }

        private void Send_button1_Click(object sender, EventArgs e)
        {
            if (Usertext_Box1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A USERNAME");
            }
            else if (Password_textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A PASSWORD");
            }
            else
            {
                User user1 = new User();
                user1.Username = Usertext_Box1.Text.Trim();
                user1.Password = Encrypt._Encrypt(Password_textBox2.Text.Trim());
                User user = User_DB.Validate_User_Password(user1.Username, user1.Password);
                Clean_Fields();
                
            }
            
        }
        private void Clean_Fields()
        {
            Usertext_Box1.Text = "";
            Password_textBox2.Text = "";
        }
    }
}
