using Venar.DTO;

namespace Venar.SVC
{
    public class ValidCreateMedic
    {
        MenuAdminSVC createMedicSVC = new MenuAdminSVC();

        public void ValidatedUser(ResultDto result, MedicDto obj)
        {
            if (string.IsNullOrEmpty(obj.Name))
            {
                result.Errors.Add("El Nombre es obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.LastName))
            {
                result.Errors.Add("El Apellido es obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.Dni))
            {
                result.Errors.Add("El Dni es obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.Mail))
            {
                result.Errors.Add("Debe ingresar el Mail.");
            }
            else if (string.IsNullOrEmpty(obj.Specialty))
            {
                result.Errors.Add("Debe ingresar una especialidad.");
            }
            else if (string.IsNullOrEmpty(obj.MedicalRegistration))
            {
                result.Errors.Add("Debe ingresar una Matricula medica.");
            }
            else if (string.IsNullOrEmpty(obj.UserName))
            {
                result.Errors.Add("El Nombre de usuario es Obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.Password))
            {
                result.Errors.Add("Debe ingresar una contraseña.");
            }
        }
        public ResultDto CreateReallyUser(MedicDto obj)
        {
            try
            {
                var resultDto = new ResultDto();

                ValidatedUser(resultDto, obj);

                if (resultDto.IsSuccess)
                {
                    createMedicSVC.CreateMedic(obj);
                }
                return resultDto;
            }
            catch (Exception ex)
            {
                throw;
            }


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
