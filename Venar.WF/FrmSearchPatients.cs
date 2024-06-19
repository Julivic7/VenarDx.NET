using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmViewPatients : Form

    {
        PatientsSVC patientsSVC;
     
        public FrmViewPatients()
        {
            InitializeComponent();
            patientsSVC = new PatientsSVC();
            
           

        }




      

        private void button2_Click(object sender, EventArgs e)

        {
            int dni;
            if (!int.TryParse(txtBxDniSearch.Text, out dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");

            }
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            var pat = patientsSVC.SearchPat(dni);



            if (pat != null)
            {

                dataGridView1.Rows.Add(
                     pat.nombre,
                     pat.apellido,
                     pat.obraSocialPaciente
                );

                txtNameSearch.Text = pat.nombre;
                txtBxLastNameSearch.Text = pat.apellido;
                txtBoxCoverSearch.Text = pat.obraSocialPaciente;
            }


            else MessageBox.Show("Paciente no encontrado");
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            string name = txtNameSearch.Text;
            string lastName = txtBxLastNameSearch.Text;
            string cover = txtBoxCoverSearch.Text;
            int dni = int.Parse(txtBxDniSearch.Text);

            bool update = patientsSVC.UpdatePatient(dni, name, lastName, cover);

            if (update)
            {
                MessageBox.Show("Datos del paciente actualizados exitosamente.");

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                var pat = patientsSVC.SearchPat(dni);


                dataGridView1.Columns.Add("NameColumn", "Nombre");
                dataGridView1.Columns.Add("LastNameColumn", "Apellido");
                dataGridView1.Columns.Add("CoverColumn", "Cover");


                if (pat != null)
                {

                    dataGridView1.Rows.Add(
                         pat.nombre,
                         pat.apellido,
                         pat.obraSocialPaciente
                    );
                }
                else

                    MessageBox.Show("Error al actualizar los datos del paciente.");



            }
        }
    }
}
        
    


