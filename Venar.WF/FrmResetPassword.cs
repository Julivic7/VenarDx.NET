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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Venar.WF
{
    public partial class FrmResetPassword : Form
    {
        //Buscar como hacer para extraer el nombre de usuario
        //de la base de datos pasando como parametro el mail

        //DataServices dataServices = new DataServices();

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
            var temporal = _temporalPass;
            var newPassword = txtNewPassConfirm.Text;



            if (txtMailPass.Text == _temporalPass)
            {
                if (txtNewPass.Text == newPassword)
                {
                    //var conn = dataServices.OpenConnection();

                    string query = "UPDATE Users SET Password = @Password,  UpdatedAt = getdate() WHERE mail = @setMail";

                    // Create a new SqlConnection and SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        // Add parameters to the command to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@setMail", setMail);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Contraseña actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("Las nuevas contraseñas no coinciden.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña temporal es incorrecta.");
            }
        }
    }

}
     
