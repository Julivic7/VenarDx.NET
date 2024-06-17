using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Entities;
using Xceed.Wpf.Toolkit;

namespace Venar.SVC
{
    public class ValidCreatePatient
    {
        Patient Patient = new Patient();


        public bool ValidatePatient(Patient patient)
        {
            
            var result = true;

            
            if (string.IsNullOrEmpty(patient.name))
            {
                throw new ArgumentException("El Nombre es obligatorio.");
            }

        o
            if (string.IsNullOrEmpty(patient.lastName))
            {
                throw new ArgumentException("El Apellido es obligatorio.");
            }

          
            if (string.IsNullOrEmpty(patient.dni) || !patient.dni.All(char.IsDigit))
            {
                throw new ArgumentException("El DNI es obligatorio y debe contener solo números.");
            }

            
            if (patient.DateOfBirth == default)
            {
                throw new ArgumentException("La Fecha de Nacimiento es obligatoria.");
            }

           
            if (string.IsNullOrEmpty(patient.gender) || !(patient.gender == "M" || patient.gender == "F" || patient.gender == "O"))
            {
                throw new ArgumentException("El Género es obligatorio y debe ser 'M', 'F' o 'O'.");
            }

           
            if (string.IsNullOrEmpty(patient.location))
            {
                throw new ArgumentException("La Localización es obligatoria.");
            }

           
            if (string.IsNullOrEmpty(patient.MedicalCoverage))
            {
                throw new ArgumentException("La Cobertura Médica es obligatoria.");
            }

           
            return result;
        }
    }


}
    


