using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
<<<<<<< Updated upstream
    public class Patient 
    {
        public  Guid Id { get; set; } 
        public string nombre  { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string obraSocialPaciente { get; set; }


        public void SomeMethod()
        {
            // El código combinado o resuelto que deseas conservar
        }
        public Patient(string nombre, string apellido, int dni,string obraSocialPaciente)
        {
        this.nombre = nombre;
            this.apellido = apellido;   
            this.dni = dni;
            this.obraSocialPaciente = obraSocialPaciente;
        }

    }
}
