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
                    Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@Password", newPassword },
                { "@setMail", setMail }
            };

                    dataServices.Execute("UPDATE Users SET Password = @Password,  UpdatedAt = getdate() WHERE mail = @setMail", parameters);

                    string message1 = "Contraseña actualizada correctamente.";

                    return message1;
                }
                else
                {
                    return "Las nuevas contraseñas no coinciden.";
                }
            }
            else
            {
                return "La contraseña temporal es incorrecta.";
            }
        }
    }
}
