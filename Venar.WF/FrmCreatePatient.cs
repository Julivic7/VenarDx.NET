using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venar.SVC;
using System.Windows.Forms;
using Venar.Entities;


namespace Venar.WF
{
    public partial class FrmCreatePatient : Form
    {
        UserServices UserServices;
        //PatientsSVC patientsSVC;
        public FrmCreatePatient()
        {
            InitializeComponent();
        }




        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            UserServices = new UserServices();
            string Name = txtNamePat.Text;
            string LastName = txtLastNamePat.Text;
            string Dni = txtDniPat.Text;
            DateTime DataBirth = dateTimePicker1.Value;
            string Gender = txtGenderPat.Text;
            string Location = txtLocaPat.Text;
            string Cover = txtMCovPat.Text;


            UserServices.CreatePatient(Name, LastName, Dni, DataBirth, Gender, Location, Cover);
            MessageBox.Show("Paciente registrado exitosamente.");

            // if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Dni) ||
            //     string.IsNullOrEmpty(DataBirth) || string.IsNullOrEmpty(Gender) ||string.IsNullOrEmpty(Location) || string.IsNullOrEmpty(Cover) )

            //{
            //  MessageBox.Show("Complete todos los campos");


            //else
            // {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
    }
}
     

