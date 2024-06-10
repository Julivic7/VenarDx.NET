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


namespace Venar.SVC
{
    public class PatientsSVC
    {

        DataServices dataService = new DataServices();

        public void CreatePatient(string name, string lastName, string dni, DateTime dateofBirth, short gender,
          string location, string medicalCoverage)
        {
            var conn = dataService.OpenConnection();

            string query = "INSERT INTO Patients (name,lastName,dni,DateOfBirth,gender,location,medicalCoverage) VALUES (@Name,@LastName,@Dni,@DateOfBirth,@Gender,@Location,@MedicalCoverage)";

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

        public List<Patient> MostrarPat()

        {
            DataServices dataService = new DataServices();
            var conn = dataService.OpenConnection();
            List<Patient> pats = new List<Patient>();

            string query = "SELECT Dni,Name,LastName,MedicalCoverage FROM patients";
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {
                    Patient patient = new Patient();
                    patient.dni = reader.GetInt32(0);
                    patient.nombre = reader.GetString(1);
                    patient.apellido = reader.GetString(2);
                    patient.obraSocialPaciente = reader.GetString(3);
                    pats.Add(patient);
                }

            }
            return pats;
        }
        public bool UpdatePatient(int dni, string name, string lastName, string cover)
        {
            var conn = dataService.OpenConnection();
            string query = "UPDATE patients SET Name = @Name, LastName = @LastName, MedicalCoverage = @Cover WHERE dni = @Dni";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Cover", cover);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
 

    public Patient SearchPat(int dni)
        {
            var conn = dataService.OpenConnection();
            string query = "SELECT Name, LastName, MedicalCoverage FROM patients WHERE dni = @Dni";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@Dni", dni);

                SqlDataReader r = cmd.ExecuteReader();
                Patient patient = new Patient();
                if (r.Read())
                {

                    patient.nombre = r.GetString(0);
                    patient.apellido = r.GetString(1);
                    patient.obraSocialPaciente = r.GetString(2);
                }

                return patient;
            }
        }

     



    } }
