using System;
using System.Collections.Generic;
using System.Data;
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

        public int GetSymptomIdByName(string symptomName)
        {
            int symptomId = 0;

            Dictionary<string, string> parameters = new Dictionary<string, string>
    {
        { "@SymptomName", symptomName }
    };

            DataTable result = dataServices.Selection("SELECT SymptomId FROM Symptoms WHERE Name = @SymptomName", parameters);

            if (result.Rows.Count > 0)
            {
                symptomId = Convert.ToInt32(result.Rows[0]["SymptomId"]);
            }

            return symptomId;
        }

        public List<string> GetSymptoms()
        {
            List<string> symptoms = new List<string>();

            DataTable result = dataServices.Selection("SELECT * FROM Symptoms", null);

            foreach (DataRow row in result.Rows)
            {
                symptoms.Add(row["Name"].ToString());
            }

            return symptoms;
        }

        public List<string> GetDiagnostic(List<int> symptomIds)
        {
            List<string> diagnostic = new List<string>();

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            for (int i = 0; i < symptomIds.Count; i++)
            {
                parameters.Add($"@symptomId{i}", symptomIds[i].ToString());
            }

            parameters.Add("@InputSymptomCount", symptomIds.Count.ToString());

            DataTable result = dataServices.Selection(@"
        SELECT i.Name, 
               COUNT(DISTINCT ils.SymptomId) AS MatchCount,
               (CAST(COUNT(DISTINCT ils.SymptomId) AS FLOAT) / @InputSymptomCount) * 100 AS MatchPercentage
        FROM Illnesses i
        JOIN IllnessSymptoms ils ON i.Id = ils.IllnessId
        WHERE ils.SymptomId IN (" + string.Join(",", symptomIds.Select((id, index) => $"@symptomId{index}")) + @")
        GROUP BY i.Name
        HAVING COUNT(DISTINCT ils.SymptomId) > 0
        ORDER BY MatchPercentage DESC", parameters);

            foreach (DataRow row in result.Rows)
            {
                string illnessName = row["Name"].ToString();
                int matchCount = Convert.ToInt32(row["MatchCount"]);
                double matchPercentage = Convert.ToDouble(row["MatchPercentage"]);

                diagnostic.Add($"{illnessName} - {matchPercentage:F2}% de coincidencia ({matchCount} de {symptomIds.Count} síntomas)");
            }

            return diagnostic;
        }

     

    }
}
