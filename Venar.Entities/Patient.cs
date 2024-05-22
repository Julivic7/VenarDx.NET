using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
    public class Patient 
    {
        public  Guid Id { get; set; } 
        public string nombre  { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string obraSocialPaciente { get; set; }


        public Patient(){
        }
        public Patient(string nombre, string apellido, string dni,string obraSocialPaciente)
        {
        this.nombre = nombre;
            this.apellido = apellido;   
            this.dni = dni;
            this.obraSocialPaciente = obraSocialPaciente;
        }

    }
}
