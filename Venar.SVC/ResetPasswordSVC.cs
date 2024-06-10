using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;
using Venar.DTO;
using Xceed.Wpf.Toolkit;

namespace Venar.SVC
{
    public class ResetPasswordSVC
    {

        DataServices dataServices = new DataServices();

        public ResultDto ResetPass(ResetPassDto resetPassDto)
        {
            var result = new ResultDto();

            if (resetPassDto.Temporal != resetPassDto.Password)
            {
                result.Errors.Add("La contraseña temporal es incorrecta.");
                return result;
            }

            if (resetPassDto.NewPassword != resetPassDto.NewPasswordConfirm)
            {
                result.Errors.Add("Las nuevas contraseñas no coinciden.");
                return result;
            }

            var conn = dataServices.OpenConnection();
            try
            {
                string query = "UPDATE Users SET Password = @Password, UpdatedAt = GETDATE() WHERE Mail = @Mail";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", resetPassDto.NewPassword);
                    cmd.Parameters.AddWithValue("@Mail", resetPassDto.SetMail);
                    cmd.ExecuteNonQuery();
                }

                result.MedicDto = null;  // You can set any relevant data here
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Error al actualizar la contraseña: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}
