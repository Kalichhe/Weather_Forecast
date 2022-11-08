using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_Forecast.DataBase.Connection_DB;
using Weather_Forecast.Forms;

namespace Weather_Forecast.DataBase.User
{
    public class User_DB
    {
        public static bool Save(User user)
        {
            try
            {
                Connection_db conn = new Connection_db();
                string sql = "INSERT INTO Users VALUES('" + user.Username + "', '" + user.Name + "', '" + user.Email + "', '"+user.Password+"', '"+user.Confirm_password+"')";
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                int amount = command.ExecuteNonQuery();
                if (amount == 1)
                {
                    conn.Disconnect();
                    return true;
                }
                else
                {
                    conn.Disconnect();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static User Validate_User_Password(string Username, string Password)
        {
            try
            {
                Connection_db conn = new Connection_db();
                string sql = string.Format("SELECT * FROM Users WHERE Username = '{0}' AND Password = '{1}'",Username,Password);
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                SqlDataReader dataReader = command.ExecuteReader();
                User user = new User();
                if (dataReader.Read())
                {
                    MessageBox.Show(String.Format("WELCOME {0}",Username.ToUpper()));
                    using (Main main = new Main())
                        main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("USERNAME OR PASSWORD INCORRECT");
                }
                return user;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static bool userExist(string Username)
        {
            try
            {
                Connection_db conn = new Connection_db();
                string sql = String.Format("SELECT COUNT (*) FROM Users WHERE Username = '{0}'",Username);
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                int count = (Int32)command.ExecuteScalar();
                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
        }
    }
}
