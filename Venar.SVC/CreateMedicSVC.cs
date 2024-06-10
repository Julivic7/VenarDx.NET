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

            
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    // Insertar en la tabla Users
                    string userQuery = "INSERT INTO Users (UserName, Password, UserType, Mail, CreatedAt, UpdatedAt) " +
                                       "OUTPUT INSERTED.UserId " +
                                       "VALUES (@UserName, @Password, 'MEDIC', @Mail, @CreatedAt, @UpdatedAt)";
                    int newUserId;
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserName", medicDto.UserName);
                        cmd.Parameters.AddWithValue("@Password", medicDto.Password);
                        cmd.Parameters.AddWithValue("@Mail", medicDto.Mail);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                        newUserId = (int)cmd.ExecuteScalar();
                    }
                    // Insertar en la tabla Medics
                    string medicQuery = "INSERT INTO Medics (UserId, Name, LastName, Dni, Mail, Specialty, MedicalRegistration, CreatedAt, UpdatedAt) " +
                                        "VALUES (@UserId, @Name, @LastName, @Dni, @Mail, @Specialty, @MedicalRegistration, @CreatedAt, @UpdatedAt)";
                    using (SqlCommand cmd = new SqlCommand(medicQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserId", newUserId);
                        cmd.Parameters.AddWithValue("@Name", medicDto.Name);
                        cmd.Parameters.AddWithValue("@LastName", medicDto.LastName);
                        cmd.Parameters.AddWithValue("@Dni", medicDto.Dni);
                        cmd.Parameters.AddWithValue("@Mail", medicDto.Mail);
                        cmd.Parameters.AddWithValue("@Specialty", medicDto.Specialty);
                        cmd.Parameters.AddWithValue("@MedicalRegistration", medicDto.MedicalRegistration);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

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
