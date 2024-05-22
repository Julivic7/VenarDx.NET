using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Venar.Entities;



namespace Venar.SVC
{  

    public class DataServices
    {
        private readonly string connectionString;

        public DataServices()
        {
            connectionString = "Data Source = sql.bsite.net\\MSSQL2016; User ID = venar_dx; Password = venar1997; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = True; ";
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // You can use this method to execute SQL queries or commands
        public void ExecuteSqlCommand(string sqlCommand)
        {
            using (SqlConnection conn = OpenConnection())
            {
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                command.ExecuteNonQuery();
            }
        }

        // If you want to fetch data, you can use this method
        public SqlDataReader ExecuteSqlQuery(string sqlQuery)
        {
            SqlConnection conn = OpenConnection();
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            return command.ExecuteReader();
        }
    }
}


