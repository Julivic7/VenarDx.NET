using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venar.WF
{
    public partial class FrmMenuMedic : Form
    {

        public FrmMenuMedic()
        {
            InitializeComponent();
        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {
            FrmCreatePatient frmCreatePatient = new FrmCreatePatient();

            frmCreatePatient.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSymptoms frmSymptoms = new FrmSymptoms();
            frmSymptoms.Show();
        }
    }
}
