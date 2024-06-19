using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;
using Venar.DTO;

namespace Venar.SVC
{
    public class MedicSVC
    {
        DataServices dataServices = new DataServices();
        public List<MedicDto> GetMedics()
        {
            var medics = new List<MedicDto>();

            DataTable result = dataServices.Selection("SELECT userName, Name, LastName, Dni, Mail, Password, Specialty, MedicalRegistration FROM Medics", null);

            foreach (DataRow row in result.Rows)
            {
                var medicDto = new MedicDto
                {
                    UserName = row["userName"].ToString(),
                    Name = row["Name"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Dni = row["Dni"].ToString(),
                    Mail = row["Mail"].ToString(),
                    Password = row["Password"].ToString(),
                    Specialty = row["Specialty"].ToString(),
                    MedicalRegistration = row["MedicalRegistration"].ToString()
                };
                medics.Add(medicDto);
            }

            return medics;
        }

        public void CreateMedic(MedicDto medicDto)
        {
            string medicQuery = "INSERT INTO Medics (Name, LastName, Dni, Mail, Specialty, MedicalRegistration) VALUES (@Name, @LastName, @Dni, @Mail, @Specialty, @MedicalRegistration)";
            Dictionary<string, string> medicParams = new Dictionary<string, string>
             {
             { "@Name", medicDto.Name },
             { "@LastName", medicDto.LastName },
             { "@Dni", medicDto.Dni },
             { "@Mail", medicDto.Mail },
             { "@Specialty", medicDto.Specialty },
             { "@MedicalRegistration", medicDto.MedicalRegistration }
    };
            dataServices.Execute(medicQuery, medicParams);

            string userQuery = "INSERT INTO Users (UserName, Password, UserType, Email) VALUES (@UserName, @Password, 'MEDIC', @Mail)";
            Dictionary<string, string> userParams = new Dictionary<string, string>
    {
            { "@UserName", medicDto.UserName },
           { "@Password", medicDto.Password },
           { "@Mail", medicDto.Mail }
    };
            dataServices.Execute(userQuery, userParams);
        }
    }
}
 