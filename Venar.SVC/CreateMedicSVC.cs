using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;
using Venar.DTO;

namespace Venar.SVC
{
    public class CreateMedicSVC
    {
        DataServices dataServices = new DataServices();
        public void CreateMedic(MedicDto medicDto)
        {
            var conn = dataServices.OpenConnection();

            //string query = "INSERT INTO Medics (username, name, lastName, dni , mail, password, specialty, medicalRegistration, createdAt) VALUES (@Username, @Name, @LastName, @Dni, @Mail, @Password, @Specialty ,@MedicalRegistration, @CreatedAt)";

            //// Create a new SqlConnection and SqlCommand
            //using (SqlCommand cmd = new SqlCommand(query, conn))
            //{
            //    // Add parameters to the command to prevent SQL injection
            //    cmd.Parameters.AddWithValue("@UserName", medicDto.UserName);
            //    cmd.Parameters.AddWithValue("@Name", medicDto.Name);
            //    cmd.Parameters.AddWithValue("@LastName", medicDto.LastName);
            //    cmd.Parameters.AddWithValue("@Dni", medicDto.Dni);
            //    cmd.Parameters.AddWithValue("@Mail", medicDto.Mail);
            //    cmd.Parameters.AddWithValue("@Password", medicDto.Password);
            //    cmd.Parameters.AddWithValue("@Specialty", medicDto.Specialty);
            //    cmd.Parameters.AddWithValue("@MedicalRegistration", medicDto.MedicalRegistration);
            //    cmd.Parameters.AddWithValue("@CreatedAt", medicDto.CreatedAt);

            //    // Execute the command
            //    cmd.ExecuteNonQuery();
            //}

            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    // Insertar en la tabla Users
                    string userQuery = "INSERT INTO Users (UserName, Password, UserType, Email) OUTPUT INSERTED.UserId VALUES (@UserName, @Password, 'MEDIC', @Mail)";
                    
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserName", medicDto.UserName);
                        cmd.Parameters.AddWithValue("@Password", medicDto.Password);
                        cmd.Parameters.AddWithValue("@Mail", medicDto.Mail);
                    }

                    // Insertar en la tabla Medics
                    string medicQuery = "INSERT INTO Medics (UserId, Name, LastName, Dni, Mail, Specialty, MedicalRegistration) VALUES (@MedicId, @Name, @LastName, @Dni, @Mail, @Specialty, @MedicalRegistration)";
                    using (SqlCommand cmd = new SqlCommand(medicQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MedicId", medicDto.Id);
                        cmd.Parameters.AddWithValue("@Name", medicDto.Name);
                        cmd.Parameters.AddWithValue("@LastName", medicDto.LastName);
                        cmd.Parameters.AddWithValue("@Dni", medicDto.Dni);
                        cmd.Parameters.AddWithValue("@Mail", medicDto.Mail);
                        cmd.Parameters.AddWithValue("@Specialty", medicDto.Specialty);
                        cmd.Parameters.AddWithValue("@MedicalRegistration", medicDto.MedicalRegistration);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }


        }
    }
}
