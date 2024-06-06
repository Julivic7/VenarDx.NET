using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Venar.SVC;
using Venar.DTO;

namespace Venar.WF
{
    public partial class FrmLogin : Form
    {
        private LoginSVC loginSVC;

        public FrmLogin()
        {
            InitializeComponent();
            loginSVC = new LoginSVC();
        }

        //Modificado por mi

        private void txtUser_Text(object sender, EventArgs e)
        {
        }
        private void txtPassword_Text(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;

            var userType = loginSVC.VerifyLogin(userName, password);

            if (userType != null)
            {
                // El login se realizo con exito
                var type = loginSVC.RedirectUser(userType);
                switch (type)
                {
                    case "admin":
                        FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(userName);
                        frmMenuAdmin.Show();
                        this.Hide();
                        break;
                    case "medic":
                        FrmMenuMedic frmMenuMedic = new FrmMenuMedic();
                        frmMenuMedic.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario desconocido");
                        ResetLoginFields();
                        break;
                }
                
            }
            else
            {
                // Mostrar los errores de validación
                MessageBox.Show("Error de validación");
            }           

        }

        private void ResetLoginFields()
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUser.Focus(); // Opcional: para poner el foco en el campo del usuario
        }


        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmForgetPassword frmForgetPassword = new FrmForgetPassword();
            frmForgetPassword.Show();
            this.Hide();

        }

        private void groupInicio_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
