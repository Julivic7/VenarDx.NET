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
        ValidCreatePatient validCreatePatient = new ValidCreatePatient();
        PatientsSVC patientsSVC;

        public FrmCreatePatient()
        {
            InitializeComponent();
            patientsSVC = new PatientsSVC();
            cmbLocation();
            cmbGender();
        }


        private void cmbLocation()
        {
            cmbLocations.DataSource= patientsSVC.GetLocations();    
            cmbLocations.DisplayMember= "nameLocation";
            cmbLocations.ValueMember= "idLocation";
        }
        private void cmbGender()
        {
            cmbGenders.DataSource = patientsSVC.GetGender();
            cmbLocations.DisplayMember = "NameGender";
            cmbLocations.ValueMember = "IdGender";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.name = txtNamePat.Text;
            patient.lastName = txtLastNamePat.Text;
            patient.dni = txtDniPat.Text;
            patient.gender = txtGenderPat.Text;
            patient.location = (Locations)cmbLocations.SelectedItem;
            patient.DateOfBirth = dateTimePicker1.Value;
            patient.MedicalCoverage = txtMCovPat.Text;


            validCreatePatient.ValidatePatient(patient);

            if (!validCreatePatient.ValidatePatient(patient))
            {
                patientsSVC.CreatePatient(patient);
                MessageBox.Show("Paciente registrado");
            }
            else
            {
                MessageBox.Show("Error al registrar paciente");
            }
        }

        
    }
}

     

