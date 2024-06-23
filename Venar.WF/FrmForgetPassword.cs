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

            bool loginSuccessful = securityServices.VerifyMail(mail);

            Debug.WriteLine(loginSuccessful);

            if (loginSuccessful)
            {
                var temporalPass = securityServices.TemporalPassword();

                mailData.MailTo = txtMail.Text;
                mailData.Subject = "Registro en Venar";
                mailData.Body = $"Hola aqui va tu clave temporal: {temporalPass}";

                mailService.SendMail(mailData);

                MessageBox.Show("Revisa la casilla del mail: " + mail);

                FrmResetPassword frmResetPassword = new FrmResetPassword(mail, temporalPass);

                frmResetPassword.ShowDialog();

                this.Hide();
            }

           
        }
    }
}
