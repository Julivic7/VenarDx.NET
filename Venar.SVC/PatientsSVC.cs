using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using Venar.Data;
using Venar.Entities;




namespace Venar.SVC
{
    public class PatientsSVC
    {

        DataServices dataService = new DataServices();



        public List<Locations> GetLocations()
        {
            string query = "SELECT * FROM Location";
            List<Locations> locations = new List<Locations>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    locations.Add(new Locations()
                    {
                        idLocation = int.Parse(row["LocationId"].ToString()),
                        nameLocation = row["Name"].ToString()
                    });
                }
            }

            return locations;
        }

        public List<Gender> GetGender()
        {
            string query = "SELECT * FROM Gender";
            List<Gender> genders = new List<Gender>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    genders.Add(new Gender()
                    {
                        IdGender = int.Parse(row["GenderId"].ToString()),
                        NameGender = row["nombre"].ToString()
                    });
                }
            }

            return genders;
        }
        public List<CoverageMedical> GetCover()
        {
            string query = "SELECT *FROM MedicalCoverage";
            List<CoverageMedical> coverageMedicals = new List<CoverageMedical>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    coverageMedicals.Add(new CoverageMedical()
                    {
                        IdCover = int.Parse(row["MedicCoveId"].ToString()),
                        NameCover = row["name"].ToString()
                    });
                }
            }

            return coverageMedicals;
        }





        public int CreatePatient(Patient patient)
        {

            Dictionary<string, string> Parts = new Dictionary<string, string>();

            string query = "INSERT INTO Patients (name, lastName, dni, DateOfBirth, GenderId, LocationId, MedicalCoverageId) " +
                "VALUES (@Name, @LastName, @Dni, @DateOfBirth, @GenderId, @LocationId, @MedicalCoverageId)";


            Parts.Add("@Name", patient.Name);
            Parts.Add("@LastName", patient.LastName);
            Parts.Add("@Dni", patient.Dni.ToString());
            Parts.Add("@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd"));
            Parts.Add("@GenderId", patient.Gender.IdGender.ToString());
            Parts.Add("@LocationId", patient.Location.idLocation.ToString());
            Parts.Add("@MedicalCoverageId", patient.MedicalCoverage.IdCover.ToString());


            var executeResult = dataService.Execute(query, Parts);

            return executeResult;
        }


        public bool UpdatePatient(Patient patient)
        {
            bool result = false;
            Dictionary<string, string> parts = new Dictionary<string, string>();
            string query = "UPDATE patients SET Name = @Name, LastName = @LastName, MedicalCoverage = @MedicalCoverage, gender =@Gender,location =@Location WHERE dni = @Dni";
            parts.Add("@Name", patient.Name);
            parts.Add("@LastName", patient.LastName);
            parts.Add("@MedicalCoverage", patient.MedicalCoverage.ToString());
            parts.Add("@Gender", patient.Gender.ToString());
            parts.Add("@Location", patient.Location.ToString());

            var dev = dataService.Execute(query, parts);
            result = true;
            return result;

        }

        public bool VerifyDni(int dni)
        {
            bool check = false;
            string query = "SELECT dni FROM Patients WHERE dni=@Dni AND Status = 1";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Dni", dni.ToString());
            DataTable dataTable = dataService.Selection(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                check = true;
            }
            else
            {
                check = false;
                Debug.WriteLine("Dni no encontrado en la base");

            }
            return check;
        }


        public Patient SearchPat(int dni)
        {
            // Consulta SQL que incluye JOINs para obtener datos de las tablas relacionadas
            string query = @"
    SELECT 
        Name, 
        LastName, 
        GenderId, 
        LocationId, 
        CoverageId 
    FROM 
        Patients 
    LEFT JOIN 
        Location l ON p.LocationId = l.LocationId
    LEFT JOIN 
        Gender g ON p.GenderId = g.GenderId
    LEFT JOIN 
        MedicalCoverage mc ON p.MedicalCoverageId = mc.MedicCoveId
    WHERE 
       dni = @Dni AND Status = 1";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Dni", dni.ToString());

            var dataTable = dataService.Selection(query, parameters);

            // Verifica que el DataTable tenga filas
            if (dataTable.Rows.Count == 0)
            {
                return null; // O lanza una excepción si prefieres
            }

            var result = dataTable.Rows[0];

            Patient patient = new Patient
            {
                Name = result["Name"].ToString(),
                LastName = result["LastName"].ToString(),
                Dni = Convert.ToInt32(result["Dni"]),
                DateOfBirth = Convert.ToDateTime(result["DateOfBirth"]),

                Location = new Locations
                {
                    idLocation = int.Parse(result["LocationId"].ToString())
                },

                Gender = new Gender
                {
                    IdGender = int.Parse(result["GenderId"].ToString())
                },

                MedicalCoverage = new CoverageMedical
                {
                    IdCover = int.Parse(result["MedicalCoverageId"].ToString())
                }
            };

            return patient;
        }
    }
}
