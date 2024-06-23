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

    }
}
