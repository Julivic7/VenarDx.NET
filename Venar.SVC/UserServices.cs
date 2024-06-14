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

        public List<MedicDto> GetMedics()
        {
            var medics = new List<MedicDto>();

            string query = "SELECT userName, Name, LastName, Dni, Mail, Password, Specialty, MedicalRegistration FROM Medics";

            using (var conn = dataService.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var medicDto = new MedicDto
                            {
                                UserName = reader.GetString(0),
                                Name = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Dni = reader.GetString(3),
                                Mail = reader.GetString(4),
                                Password = reader.GetString(5),
                                Specialty = reader.GetString(6),
                                MedicalRegistration = reader.GetString(7)
                            };
                            medics.Add(medicDto);
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
        
        //BORRAR======================================================

        //CORREGIR Y ORDENAR
        
        



    }
}



