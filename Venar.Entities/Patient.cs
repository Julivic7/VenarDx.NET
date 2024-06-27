using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.SVC;

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
            public Gender gender { get; set; }
            public  Locations location { get; set; }

            public Patient()
            {
            }

            public Patient(Guid id, string name, string lastName, string dni, string medicalCoverage,DateTime DateOfBirth, Gender gender,Locations location)
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

