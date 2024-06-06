using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Data;

namespace Venar.SVC
{    
    public class SymptomsServices
    {
        DataServices dataServices = new DataServices();
        public SymptomsServices()
        {

        }        

        public List<string> GetSymptoms()
        {
            List<string> symptoms = new List<string>();
            var conn = dataServices.OpenConnection();
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
            var conn = dataServices.OpenConnection();
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
            var conn = dataServices.OpenConnection();
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
    }

    
}
