using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmViewPatients : Form

    {    //PatientsSVC patientsSVC;
         List<Patient> pats;
        public FrmViewPatients()
        {
            pats= new List<Patient>();
            InitializeComponent();
            this.pats = pats;
            popularDataGridView();
        }

        private void popularDataGridView()
        {
          
            
            dataGridView1.Columns.Add("NameColumn", "Nombre");
            dataGridView1.Columns.Add("LastNameColumn", "Apellido");
            dataGridView1.Columns.Add("DniColumn", "DNI");
            dataGridView1.Columns.Add("CoverColumn", "Cover");
          
            foreach (var paciente in pats)
            {

                dataGridView1.Rows.Add(
                     paciente.dni,
                     paciente.nombre,
                     paciente.apellido,
                     paciente.obraSocialPaciente
                ); ;
            }
        }
    }
}
        
    


