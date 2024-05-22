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

namespace Venar.WF
{
    public partial class FrmLogin : Form
    {
        private SecurityServices securityServices;

        public FrmLogin()
        {
            InitializeComponent();
            securityServices = new SecurityServices();
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
           
            var userType = securityServices.VerifyLogin(userName, password);

            Debug.WriteLine(userType);

            if (userType != null)
            {
                switch (userType)
                {
                    case "ADMINISTRADOR":
                        FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(userName);
                        frmMenuAdmin.Show();
                        this.Hide();
                        break;
                    case "MEDICO":
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
                MessageBox.Show("Usuario o contraseña incorrecto");
                ResetLoginFields();
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
    }
}
