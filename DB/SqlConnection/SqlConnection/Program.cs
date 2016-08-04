using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MySqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            ConnectionStringSettings settings =
      ConfigurationManager.ConnectionStrings["MyConn"];

            using (SqlConnection connection = new SqlConnection(
              settings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from FEATURES", connection);
                command.Connection.Open();
               SqlDataReader sr = command.ExecuteReader();
                while (sr.Read())
                {
                    string a = sr.GetString(1);
                }
            }
        }
    }
}
