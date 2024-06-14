using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;
using Xceed.Wpf.Toolkit;

namespace Venar.SVC
{
    public class ResetPasswordSVC
    {

        DataServices dataServices = new DataServices();

        public string ResetPass(string temporal, string password, string newPassword, string newPasswordConfirm, string setMail)
        {
            
            if (password == temporal)
            {
                if (newPassword == newPasswordConfirm)
                {
                    var conn = dataServices.OpenConnection();

                    string query = "UPDATE Users SET Password = @Password,  UpdatedAt = getdate() WHERE mail = @setMail";

                    // Create a new SqlConnection and SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to the command to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@setMail", setMail);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                    string message1 = "Contraseña actualizada correctamente.";

                    return message1;
                }
                else
                {
                    return  "Las nuevas contraseñas no coinciden.";
                }
            }
            else
            {
                return "La contraseña temporal es incorrecta.";
            }
            return "";
        }
    }
}
