using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;

namespace Venar.SVC
{
    public class SecurityServices
    {
        DataServices dataService = new DataServices();

        public string VerifyLogin(string userName, string password)
        {
            string userType = null;

            var conn = dataService.OpenConnection();


            // Write the SQL query to validate the user
            string query = "SELECT UserType FROM Users WHERE Username = @Username AND Password = @Password";

            // Create a command object
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to the SQL query
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {

                    var result = cmd.ExecuteScalar();

                    // Verificamos si se obtuvo algún resultado
                    if (result != null)
                    {
                        userType = result.ToString(); // Asignamos el tipo de usuario obtenido de la consulta
                        Debug.WriteLine("Login successful. User type: " + userType);
                    }
                    else
                    {
                        Debug.WriteLine("User doesn't exist");
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error while validating login: " + ex.Message);
                }
                return userType;
            }

        }
        public bool VerifyMail(string mail)
        {
            bool loginSuccessful = false;

            var conn = dataService.OpenConnection();

            string query = "SELECT COUNT(*) FROM Users WHERE Mail = @Mail";


            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to the SQL query
                cmd.Parameters.AddWithValue("@Mail", mail);

                try
                {
                    // Execute the query and get the result
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Check if at least one user was found with the provided credentials
                    if (count > 0)
                    {
                        loginSuccessful = true;
                        Debug.WriteLine("Success");
                    }
                    else
                    {
                        loginSuccessful = false;
                        Debug.WriteLine("User doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error while validating login: " + ex.Message);
                }

            }

            return loginSuccessful;
        }
        public string TemporalPassword()
        {
            var clave = new Random().Next().ToString();

            return clave;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
