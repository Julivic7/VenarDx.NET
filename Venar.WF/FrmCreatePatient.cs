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
using System.Diagnostics.Eventing.Reader;


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
            cmbCoverMedical();
        }


        private void cmbLocation()
        {
            cmbLocations.DataSource = patientsSVC.GetLocations();
            cmbLocations.DisplayMember = "nameLocation";
            cmbLocations.ValueMember = "idLocation";
        }
        private void cmbGender()
        {
            cmbGenders.DataSource = patientsSVC.GetGender();
            cmbGenders.DisplayMember = "NameGender";
            cmbGenders.ValueMember = "IdGender";
        }
        private void cmbCoverMedical()
        {
            cmbCoverMed.DataSource = patientsSVC.GetCover();
            cmbCoverMed.DisplayMember = "NameCover";
            cmbCoverMed.ValueMember = "IdCover";
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
            Patient patient = new Patient
            {
                Name = txtNamePat.Text,
                LastName = txtLastNamePat.Text,
                Dni = int.Parse(txtDniPat.Text),
                DateOfBirth = dateTimePicker1.Value,
                Gender = new Gender { IdGender = (int)cmbGenders.SelectedValue },
                Location = new Locations { idLocation = (int)cmbLocations.SelectedValue },
                MedicalCoverage = new CoverageMedical { IdCover = (int)cmbCoverMed.SelectedValue }
            };

            ValidCreatePatient validCreatePatient = new ValidCreatePatient();

            if (validCreatePatient.ValidatePatient(patient))
            {
                int patientId = patientsSVC.CreatePatient(patient);
                MessageBox.Show("Paciente registrado con exito");

            }
            else {
                MessageBox.Show("Paciente no registrado");
        }  
        }
    }
}
