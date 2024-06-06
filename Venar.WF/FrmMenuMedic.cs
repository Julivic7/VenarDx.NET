using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venar.Entities;

namespace Venar.WF
{
    public partial class FrmMenuMedic : Form
    {

        public FrmMenuMedic()
        {
            InitializeComponent();
        }
        private void openFormPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnCreatePatient_Click(object sender, EventArgs e)
        {
            openFormPanel(new FrmCreatePatient());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           openFormPanel(new FrmSymptoms());
        }

        private void btnFinishSession_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            openFormPanel(new FrmViewPatients());  
        }
    }
}
