using System.Data.SqlClient;



namespace Venar.Data
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


