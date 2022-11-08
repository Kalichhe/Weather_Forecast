using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Forecast.DataBase.User
{
    public class User
    {
        private string username;
        private string name;
        private string email;
        private string password;
        private string confirm_password;

        public User()
        {
            this.username = "";
            this.name = "";
            this.email = "";
            this.password = "";
            this.confirm_password = "";
        }

        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Confirm_password { get => confirm_password; set => confirm_password = value; }
    }
}
