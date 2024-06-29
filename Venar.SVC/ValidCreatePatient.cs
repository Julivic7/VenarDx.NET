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
        public bool ValidatePatient(Patient patient)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            if (string.IsNullOrEmpty(patient.Name))
                throw new ArgumentException("El Nombre es obligatorio.");

            if (string.IsNullOrEmpty(patient.LastName))
                throw new ArgumentException("El Apellido es obligatorio.");

            if (string.IsNullOrEmpty(patient.Dni.ToString()) || !patient.Dni.ToString().All(char.IsDigit))
                throw new ArgumentException("El DNI es obligatorio y debe contener solo números.");

            if (patient.DateOfBirth == default)
                throw new ArgumentException("La Fecha de Nacimiento es obligatoria.");

           if (patient.Gender == null)
               throw new ArgumentException("El Género es obligatorio.");

            if (patient.Location == null)
                throw new ArgumentException("La Localización es obligatoria.");

            if (patient.MedicalCoverage == null)
                throw new ArgumentException("La Cobertura Médica es obligatoria.");

            return true;
        }
    }
}