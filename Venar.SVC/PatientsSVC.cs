﻿using System;
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
                        NameGender = row["NamGender"].ToString()
                    });
                }
            }

            return genders;
        }


        public int CreatePatient(Patient patient)
        {

            Dictionary<string, string> Parts = new Dictionary<string, string>();

            string query = "INSERT INTO Patients (name, lastName, dni, DateOfBirth, gender, location, medicalCoverage) VALUES (@Name, @LastName, @Dni, @DateOfBirth, @Gender, @Location, @MedicalCoverage)";


            Parts.Add("@Name", patient.name);
            Parts.Add("@LastName", patient.lastName);
            Parts.Add("@Dni", patient.dni.ToString());
            Parts.Add("@DateOfBirth", patient.DateOfBirth.ToString());
            Parts.Add("@Gender", patient.gender.ToString());
            Parts.Add("@Location", patient.location.ToString());
            Parts.Add("@MedicalCoverage", patient.MedicalCoverage);


            var executeResult = dataService.Execute(query, Parts);

            return executeResult;
        }


        public bool UpdatePatient(Patient patient)
        {
            bool result = false;
            Dictionary<string, string> parts = new Dictionary<string, string>();
            string query = "UPDATE patients SET Name = @Name, LastName = @LastName, MedicalCoverage = @MedicalCoverage, gender =@Gender,location =@Location WHERE dni = @Dni";
            parts.Add("@Name", patient.name);
            parts.Add("@LastName", patient.lastName);
            parts.Add("@MedicalCoverage", patient.MedicalCoverage);
            parts.Add("@Gender", patient.gender.ToString());
            parts.Add("@Location", patient.location.ToString());

            var dev = dataService.Execute(query, parts);
            result = true;
            return result;

        }


        public Patient SearchPat(int dni)
        {
            Dictionary<string, string> parts = new Dictionary<string, string>();
            string query = "SELECT Name, LastName, MedicalCoverage FROM patients WHERE dni = @Dni";

            parts.Add("@Dni", dni.ToString());

            var dev = dataService.Selection(query, parts).Rows[0];

            return new Patient()
            {

                name = dev["@Name"].ToString(),
                lastName = dev["@LastName"].ToString(),
                location = (Locations)dev["@Locations"],
                gender = Convert.ToInt16(dev["Gender"]).ToString(),
                MedicalCoverage = dev["@MedicalCoverage"].ToString(),



            };
        }

       
    }
}
