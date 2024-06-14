using System.Windows.Forms;
using Venar.DTO;
using Venar.Entities;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace Venar.WF
{
    public partial class FrmViewMedics : Form
    {
        private List<MedicDto> medics;

        public FrmViewMedics(List<MedicDto> medics)
        {
            InitializeComponent();
            this.medics = medics;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            // Add DataGridView columns
            dataGridView1.Columns.Add("UserNameColumn", "Usuario");
            dataGridView1.Columns.Add("NameColumn", "Nombre");
            dataGridView1.Columns.Add("LastNameColumn", "Apellido");
            dataGridView1.Columns.Add("DniColumn", "DNI");
            dataGridView1.Columns.Add("MailColumn", "Correo");
            dataGridView1.Columns.Add("SpecialityColumn", "Especialidad");
            dataGridView1.Columns.Add("MedicalRegistrationColumn", "Registro Médico");

            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.Width = 200;
            //}

            // Populate DataGridView with medics data
            foreach (var medic in medics)
            {
                dataGridView1.Rows.Add(
                    medic.UserName,
                    medic.Name,
                    medic.LastName,                   
                    medic.Mail,
                    medic.Specialty
                );
            }
        }

      
    }
}
