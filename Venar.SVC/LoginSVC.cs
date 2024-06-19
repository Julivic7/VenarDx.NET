using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class LoginSVC
    {
        DataServices dataService = new DataServices();
        public User VerifyLogin(string userName, string password)
        {
            string query = "SELECT UserId, UserName, UserType FROM Users WHERE UserName = @UserName AND Password = @Password";
            Dictionary<string, string> parameters = new Dictionary<string, string>
    {
        { "@UserName", userName },
        { "@Password", password }
    };

            DataTable result = dataService.Selection(query, parameters);

            if (result.Rows.Count > 0)
            {
                return new User
                {
                    UserId = Convert.ToInt32(result.Rows[0]["UserId"]),
                    UserName = result.Rows[0]["UserName"].ToString(),
                    UserType = result.Rows[0]["UserType"].ToString()
                };
            }
            else
            {
                return null;
            }
        }
    

  

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

        Dictionary<string, string> parameters = new Dictionary<string, string>
    {
        { "@Mail", mail }
    };

        DataTable result = dataService.Selection("SELECT COUNT(*) FROM Users WHERE Mail = @Mail", parameters);

        if (result.Rows.Count > 0)
        {
            int count = Convert.ToInt32(result.Rows[0][0]);
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
        else
        {
            loginSuccessful = false;
            Debug.WriteLine("Error while validating login");
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
