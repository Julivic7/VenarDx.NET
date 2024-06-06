using Venar.Entities;
using Venar.SVC;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Venar.WF
{
    public partial class FrmPatients : Form
    {
        private UserServices userServices;

        public FrmPatients()
        {
            InitializeComponent();
            userServices = new UserServices();
           // LoadPatients();
        }
       // private void LoadPatients()
        //{
           // var patients = userServices.GetPatients();

         //   dataGridView1.DataSource = patients;

           // dataGridView1.AutoGenerateColumns = false;

            //dataGridView1.Columns.Clear();

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    DataPropertyName = "Id",
              //  HeaderText = "ID",
                //Visible = false
            //});

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            //{
              //  DataPropertyName = "nombre",
                //HeaderText = "Nombre"
           // });

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            //{
              //  DataPropertyName = "apellido",
               // HeaderText = "Apellido"
            //});

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
          //  {
            //    DataPropertyName = "dni",
              //  HeaderText = "DNI"
            //});

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            //{
              //  DataPropertyName = "obraSocialPaciente",
                //HeaderText = "Obra Social"
            //});
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in clickedRow.Cells)
                {
                    Debug.WriteLine(dataGridView1.Columns[cell.ColumnIndex].HeaderText + ": " + cell.Value);
                }
            }
        }


        private void FrmPatients_Load(object sender, EventArgs e)
        {
        }
    }
}
