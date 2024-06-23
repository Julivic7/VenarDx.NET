using System;
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
    public class DiagnosticSVC
    {
        DataServices dataService = new DataServices();
   
         
        public DiagnosticSVC()
        {

          
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

            DataTable result = dataService.Selection(@"
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



