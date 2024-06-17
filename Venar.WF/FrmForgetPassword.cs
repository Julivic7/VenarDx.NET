using System.Diagnostics;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{

    public partial class FrmForgetPassword : Form
    {
        LoginSVC loginSvc = new LoginSVC();
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

            bool loginSuccessful = loginSvc.VerifyMail(mail);

            Debug.WriteLine(loginSuccessful);

            if (loginSuccessful)
            {
                var temporalPass = loginSvc.TemporalPassword();

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
