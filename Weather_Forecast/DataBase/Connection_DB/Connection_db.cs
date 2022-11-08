using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast.DataBase.Connection_DB
{
    class Connection_db
    {
        SqlConnection conn;
        public Connection_db()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalic\\source\\repos\\Weather_Forecast\\Weather_Forecast\\DataBase\\WeatherForecastDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        public SqlConnection Connect()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
