using System.Data.SqlClient;
using System.Diagnostics;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class LoginSVC
    {
        DataServices dataService = new DataServices();

        public User VerifyLogin(string userName, string password)
        {
            string userType = null;

            var conn = dataService.OpenConnection();


            // Write the SQL query to validate the user
            string query = "SELECT UserId, UserName, UserType FROM Users WHERE UserName = @UserName AND Password = @Password";
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var user = new User
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            UserType = reader.GetString(2)
                        };

                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

        }


        //VERIFIVAR REDISTRIBUCION o ELIMINACION DE LOS SIGUIENTES METODOS

        public string RedirectUser(User user)
        {
            if (user.UserType == "ADMIN")
            {
                return "admin";
            }
            else if (user.UserType == "MEDIC")
            {
                return "medic";
            }
            else
            {
                return null;
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


    }
}
