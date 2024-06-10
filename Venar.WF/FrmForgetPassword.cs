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
using Venar.Entities;
using Venar.SVC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Venar.WF
{
   
    public partial class FrmForgetPassword : Form
    {
        LoginSVC securityServices = new LoginSVC();
        MailData mailData = new MailData();
        MailService mailService = new MailService();
        ForgetPasswordSVC forgetPasswordSVC = new ForgetPasswordSVC();

        public FrmForgetPassword()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var mail = txtMail.Text;
            var result = forgetPasswordSVC.HandleForgotPassword(mail);

            if (result.IsSuccess)
            {
                string temporalPass = result.MedicDto.Password;

                MessageBox.Show("Revisa la casilla del mail: " + mail);

                FrmResetPassword frmResetPassword = new FrmResetPassword(mail, temporalPass);
                frmResetPassword.ShowDialog();

                this.Hide();
            }
            else
            {
                string errorMessage = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(errorMessage);
            }


        }
    }
}
