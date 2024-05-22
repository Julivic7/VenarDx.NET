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

namespace Venar.WF
{
    public partial class FrmMenuAdmin : Form
    {
        public string LoggedUserName { get; set; }
        UserServices userServices = new UserServices();

        // Constructor that accepts a username parameter
        public FrmMenuAdmin(string userName)
        {
            InitializeComponent();
            LoggedUserName = userName ?? "usuario";
            label1.Text = "Bienvenido " + LoggedUserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateMedic_Click(object sender, EventArgs e)
        {
            FrmCreateMedic frmCreateMedic = new FrmCreateMedic();
            frmCreateMedic.Show();

        }

        private void btnShowMedic_Click(object sender, EventArgs e)
        {
            List<Medic> medics = userServices.GetMedics();
            FrmViewMedics frmViewMedics = new FrmViewMedics(medics);
            frmViewMedics.Show();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
