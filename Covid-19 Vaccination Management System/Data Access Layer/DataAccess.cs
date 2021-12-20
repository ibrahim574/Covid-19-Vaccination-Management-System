using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Covid_19_Vaccination_Management_System.Data_Access_Layer
{
    class DataAccess:IDisposable
    {
        public static string type;

        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["COVID"].ConnectionString);
            connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
