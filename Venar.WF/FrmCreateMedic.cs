using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmCreateMedic : Form
    {
        UserServices userServices = new UserServices();
        SecurityServices securityServices = new SecurityServices();

        public FrmCreateMedic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string name = txtName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string dni = txtDni.Text.Trim();
            string mail = txtMail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = txtSpeciality.Text.Trim();
            //string medicalRegistration = txtMedicalRegistration.Text.Trim();
            var isValidMail = securityServices.IsValidEmail(mail);


            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) ||
         string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password) ||
         string.IsNullOrEmpty(userType) ) //Agregar despues de implementar|| string.IsNullOrEmpty(medicalRegistration))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de correo electrónico
            if (!isValidMail)
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Implementar cunado solicuionemos las FK de User + Medics
            //userServices.CreateMedic(userName, name, lastName, dni, mail, password, speciality, medicalRegistration);
            userServices.CreateUser( userName,  name,  lastName,  dni,  mail,  password,  userType);

            this.Close();

            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
