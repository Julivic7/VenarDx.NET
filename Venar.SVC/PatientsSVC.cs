using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Venar.Entities;
using Venar.Data;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Data;




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


       // public Patient SearchPat(int dni)
        //{
          //  Dictionary<string, string> parts = new Dictionary<string, string>();
            //string query = "SELECT Name, LastName, MedicalCoverage FROM patients WHERE dni = @Dni";

            //pa//rts.Add("@Dni", dni.ToString());

            //var dev = dataService.Selection(query, parts).Rows[0];

            //return new Patient()
            //{

              //  Name = dev["@Name"].ToString(),
                //LastName = dev["@LastName"].ToString(),
                //Location = (Locations)dev["@Locations"],
               // Gender = (Gender)dev["Gender"],
                //MedicalCoverage = (CoverageMedical)dev["@MedicalCoverage"],



            //};
        }

       
    }

