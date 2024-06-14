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
            public int dni { get; set; }
            public string MedicalCoverage { get; set; }
            public short gender { get; set; }
            public string localidad { get; set; }

            public Patient()
            {
            }

            public Patient(Guid id, string name, string lastName, int dni, string medicalCoverage, short gender, string localidad)
            {
                Id = id;
                this.name = name;
                this.lastName = lastName;
                this.dni = dni;
                MedicalCoverage = medicalCoverage;
                this.gender = gender;
                this.localidad = localidad;
            }
        }
    }

