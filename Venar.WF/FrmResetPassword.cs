using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Venar.Entities;
using Venar.SVC;
using Venar.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Venar.WF
{
    public partial class FrmResetPassword : Form
    {
        //Buscar como hacer para extraer el nombre de usuario
        //de la base de datos pasando como parametro el mail

        ResetPasswordSVC resetPasswordSVC = new ResetPasswordSVC();
        ResetPassDto resetPassDto;
        private string _temporalPass;
        private string setMail;
        private string LoggedUserMail;
        public FrmResetPassword(string mail, string temporalPass)
        {
            InitializeComponent();
            _temporalPass = temporalPass;
            setMail = mail;

            LoggedUserMail = mail ?? "usuario";
            label7.Text = LoggedUserMail;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validacion de contraseñas correctas
            resetPassDto = new ResetPassDto
            {
                Temporal = _temporalPass,
                Password = txtMailPass.Text,
                NewPassword = txtNewPass.Text,
                NewPasswordConfirm = txtNewPassConfirm.Text,
                SetMail = setMail
            };

            var result = resetPasswordSVC.ResetPass(resetPassDto);
            if (result.IsSuccess)
            {
                MessageBox.Show("Contraseña actualizada correctamente.");
            }
            else
            {
                string errorMessage = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(errorMessage);
            }
        }
               
    }

}
     
