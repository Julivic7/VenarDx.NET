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
using Venar.DTO;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmCreateMedic : Form
    {
        MedicSVC createMedicSVC = new MedicSVC();   
        ValidCreateMedic validCreateMedicSVC = new ValidCreateMedic();  
        MedicDto medicDto = new MedicDto();

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

            medicDto = new MedicDto
            {
                UserName = txtUserName.Text,
                Name = txtName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Mail = txtMail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Specialty = txtSpecialty.Text.Trim(),
                MedicalRegistration = txtMedicalRegistration.Text.Trim()
            };                        
            //VERIFICAR TAMBIEN QUE NO HAYA OTRO MAIL IGUAL EN LA BASE DE DATOS
            var isValidMail = validCreateMedicSVC.IsValidEmail(txtMail.Text.Trim());
            if(isValidMail != false)
            {
                ResultDto result = validCreateMedicSVC.CreateReallyUser(medicDto);
                if (result.IsSuccess)
                {
                    // El médico fue creado con éxito, cerrar el formulario
                    MessageBox.Show("El médico ha sido registrado con éxito.");
                    this.Close();
                }
                else
                {
                    // Mostrar los errores de validación
                    string errorMessage = string.Join("\n", result.Errors);
                    MessageBox.Show(errorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            // Verificar si la validación fue exitosa
                               
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
