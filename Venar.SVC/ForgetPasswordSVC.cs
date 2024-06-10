using System;
using System.Data.SqlClient;
using Venar.Data;
using Venar.DTO;
using Venar.Entities;

namespace Venar.SVC
{
    public class ForgetPasswordSVC
    {
        DataServices dataServices = new DataServices();
        MailService mailService = new MailService();
        LoginSVC loginService = new LoginSVC();

        public ResultDto HandleForgotPassword(string email)
        {
            var result = new ResultDto();

            if (!loginService.VerifyMail(email))
            {
                result.Errors.Add("El mail no es correcto.");
                return result;
            }

            string temporalPass = GenerateTemporalPassword();

            try
            {
                MailData mailData = new MailData
                {
                    MailTo = email,
                    Subject = "Registro en Venar",
                    Body = $"Hola, aquí va tu clave temporal: {temporalPass}"
                };

                mailService.SendMail(mailData);
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Error al enviar el mail: {ex.Message}");
                return result;
            }

            result.MedicDto = new MedicDto { Mail = email, Password = temporalPass };
            return result;
        }

     
        private string GenerateTemporalPassword()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}
