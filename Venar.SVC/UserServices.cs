﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Venar.Entities;
using System.Data;
using Venar.Data;
using Venar.DTO;


namespace Venar.SVC
{
    public class UserServices
    {
        DataServices dataService = new DataServices();
        private List<User> users;
         
        public UserServices()
        {

            users = new List<User>();
        }
        //hacer private
        public void CreateMedic(string userName, string name, string lastName, string dni, string mail, string password, string speciality, string medicalRegistration)
        {
            Debug.WriteLine(userName);

            var conn = dataService.OpenConnection();

            string query = "INSERT INTO Medics (username, name, lastName, dni , mail, password, speciality , medicalRegistration) VALUES (@Username, @Name, @LastName, @Dni, @Mail, @Password, @Speciality, @MedicalRegistration)";

            // Create a new SqlConnection and SqlCommand
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Mail", mail);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Speciality", speciality);
                cmd.Parameters.AddWithValue("@MedicalRegistration", medicalRegistration);

                // Execute the command
                cmd.ExecuteNonQuery();
            }

        }

        public void CreatePatient(string name, string lastName, string dni, DateTime dateofBirth, string gender,
          string location, string medicalCoverage)
        {
            var conn = dataService.OpenConnection();

            string query = "INSERT INTO patients(name,lastName,dni,DateOfBirth,gender,location,medicalCoverage) VALUES (@Name,@LastName,@Dni,@DateOfBirth,@Gender,@Location,@MedicalCoverage)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateofBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@MedicalCoverage", medicalCoverage);

                cmd.ExecuteNonQuery();


            }
        }

        public List<Patient> GetPatients()
        {
            var patients = new List<Patient>();

            string query = "SELECT PatientsId, Name, LastName, Dni, MedicalCoverage FROM Patients";

            var conn = dataService.OpenConnection();


            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var patient = new Patient
                {
                    Id = reader.GetGuid(0),
                    nombre = reader.GetString(1),
                    apellido = reader.GetString(2),
                    dni = reader.GetString(3),
                    obraSocialPaciente = reader.GetString(4)
                };
                patients.Add(patient);
            }
            return patients;
        }


        //public string GetMedicsInfo()
        //{
        //    List<Medic> medics = GetMedics();
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var medic in medics)
        //    {
        //        sb.AppendLine($"Username: {medic.userName}");
        //        sb.AppendLine($"Name: {medic.name}");
        //        sb.AppendLine($"Last Name: {medic.lastName}");
        //        sb.AppendLine($"DNI: {medic.dni}");
        //        sb.AppendLine($"Mail: {medic.mail}");
        //        sb.AppendLine($"Speciality: {medic.speciality}");
        //        sb.AppendLine($"Medical Registration: {medic.medicalRegistration}");
        //        sb.AppendLine("-----------");
        //    }

        //    string consolidatedInfo = sb.ToString();

        //    return consolidatedInfo;
        //}

        public List<Medic> GetMedics()
        {
            var medics = new List<Medic>();

            string query = "SELECT userName, Name, LastName, Dni, Mail, Password, Speciality, MedicalRegistration FROM Medics";

            using (var conn = dataService.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var medic = new Medic
                            {
                                userName = reader.GetString(0),
                                name = reader.GetString(1),
                                lastName = reader.GetString(2),
                                dni = reader.GetString(3),
                                mail = reader.GetString(4),
                                password = reader.GetString(5),
                                speciality = reader.GetString(6),
                                medicalRegistration = reader.GetString(7)
                            };
                            medics.Add(medic);
                        }
                    }
                }
            }
            return medics;
        }

        public List<string> GetSymptoms()
        {
            List<string> symptoms = new List<string>();
            var conn = dataService.OpenConnection();
            string query = "SELECT * FROM Symptoms";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                symptoms.Add(reader["Name"].ToString());
            }

            reader.Close();

            return symptoms;
        }

        public List<string> GetDiagnostic(List<int> symptomIds)
        {
            var conn = dataService.OpenConnection();
            List<string> diagnostic = new List<string>();

            try
            {
                string query = @"
                    SELECT i.Name, 
                           COUNT(DISTINCT ils.SymptomId) AS MatchCount,
                           (CAST(COUNT(DISTINCT ils.SymptomId) AS FLOAT) / @InputSymptomCount) * 100 AS MatchPercentage
                    FROM Illnesses i
                    JOIN IllnessSymptoms ils ON i.Id = ils.IllnessId
                    WHERE ils.SymptomId IN (" + string.Join(",", symptomIds.Select((id, index) => $"@symptomId{index}")) + @")
                    GROUP BY i.Name
                    HAVING COUNT(DISTINCT ils.SymptomId) > 0
                    ORDER BY MatchPercentage DESC";

                SqlCommand command = new SqlCommand(query, conn);

                for (int i = 0; i < symptomIds.Count; i++)
                {
                    command.Parameters.AddWithValue($"@symptomId{i}", symptomIds[i]);
                }

                command.Parameters.AddWithValue("@InputSymptomCount", symptomIds.Count);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string illnessName = reader["Name"].ToString();
                    int matchCount = (int)reader["MatchCount"];
                    double matchPercentage = (double)reader["MatchPercentage"];

                    diagnostic.Add($"{illnessName} - {matchPercentage:F2}% de coincidencia ({matchCount} de {symptomIds.Count} síntomas)");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return diagnostic;
        }



        public int GetSymptomIdByName(string symptomName)
        {
            var conn = dataService.OpenConnection();
            int symptomId = 0;

            try
            {
                string query = "SELECT SymptomId FROM Symptoms WHERE Name = @SymptomName";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@SymptomName", symptomName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    symptomId = (int)reader["SymptomId"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return symptomId;
        }

        //BORRAR======================================================
        private void CreateUser(UserDto userDto)
        {           

            var conn = dataService.OpenConnection();

            string query = "INSERT INTO Users (username, name, lastName, dni , mail, password) VALUES (@Username, @Name, @LastName, @Dni, @Mail, @Password)";

            // Create a new SqlConnection and SqlCommand
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@UserName", userDto.UserName);
                cmd.Parameters.AddWithValue("@Name", userDto.Name);
                cmd.Parameters.AddWithValue("@LastName", userDto.LastName);
                cmd.Parameters.AddWithValue("@Dni", userDto.Dni);
                cmd.Parameters.AddWithValue("@Mail", userDto.Mail);
                cmd.Parameters.AddWithValue("@Password", userDto.Password);
                //cmd.Parameters.AddWithValue("@UserType", userDto.UserType);

                // Execute the command
                cmd.ExecuteNonQuery();
            }
          
        }
        //BORRAR======================================================

        //CORREGIR Y ORDENAR
        private void ValidatedUser(ResultDto result, UserDto obj)
        {
            if (string.IsNullOrEmpty(obj.Name))
            {
                result.Errors.Add("El Nombre es obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.Mail))
            {
                result.Errors.Add("El E-mail es obligatorio.");
            }
            else if (string.IsNullOrEmpty(obj.Password))
            {
                result.Errors.Add("Debe ingresar una contraseña.");
            }
            else if (string.IsNullOrEmpty(obj.UserName))
            {
                result.Errors.Add("Debe ingresar el nombre de Usuario.");
            }
            else if (string.IsNullOrEmpty(obj.LastName))
            {
                result.Errors.Add("Debe ingresar el nombre de Usuario.");
            }
            else if (string.IsNullOrEmpty(obj.Dni))
            {
                result.Errors.Add("Debe ingresar el DNI.");
            }
       
            
        }

        public ResultDto CreateReallyUser(UserDto obj)
        {           
            try
            {
                var resultDto = new ResultDto();

                ValidatedUser(resultDto, obj);

                if(resultDto.IsSuccess)
                {
                    CreateUser(obj);
                }
                return resultDto;

            }

            catch (Exception ex)
            {
                throw;
            }

             
        }



    }
}



