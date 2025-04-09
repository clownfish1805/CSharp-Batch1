using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Util
{
    public class DBConnection
    {
        private static SqlConnection connection;

        static DBConnection()
        {
            try
            {
                connection = new SqlConnection("Server=DESKTOP-S6D65HG\\SQLEXPRESS01;Database=insurance_db;Trusted_Connection=True;Encrypt=False;");
                connection.Open();
                Console.WriteLine("Connected to Insurance DB");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
            }
        }

        public static SqlConnection GetConnection()
        {
            return connection;
        }

    }
}
