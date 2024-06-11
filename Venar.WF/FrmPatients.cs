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
        UserServices userServices;
        PatientsSVC patientsSVC;
        public FrmCreatePatient()
        {
            InitializeComponent();
            patientsSVC = new PatientsSVC();
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





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            userServices = new UserServices();
            string Name = txtNamePat.Text;
            string LastName = txtLastNamePat.Text;
            string Dni = txtDniPat.Text;
            DateTime DataBirth = dateTimePicker1.Value;
            string Gender = txtGenderPat.Text;
            string Location = txtLocaPat.Text;
            string Cover = txtMCovPat.Text;


            if (short.TryParse(txtGenderPat.Text, out short gender))
            {
                patientsSVC.CreatePatient(Name, LastName, Dni, DataBirth, gender, Location, Cover);
                MessageBox.Show("Paciente registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el género.");
            }
        }

    }
}



