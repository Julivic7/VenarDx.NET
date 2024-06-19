using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{

        public class Patient
        {
            public Guid Id { get; set; }
            public string name { get; set; }
            public string lastName { get; set; }
            public string dni { get; set; }
            public string MedicalCoverage { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string gender { get; set; }
            public string location { get; set; }

            public Patient()
            {
            }

            public Patient(Guid id, string name, string lastName, string dni, string medicalCoverage,DateTime DateOfBirth, string gender, string location)
            {
                Id = id;
                this.name = name;
                this.lastName = lastName;
                this.dni = dni;
                MedicalCoverage = medicalCoverage;
                this.DateOfBirth = DateOfBirth;
                this.gender = gender;
                this.location = location;
            }
        }
    }

