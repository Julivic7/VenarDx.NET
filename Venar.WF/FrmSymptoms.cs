using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmSymptoms : Form
    {
        private SymptomsServices symptomsServices;
        public FrmSymptoms()
        {
            InitializeComponent();
            symptomsServices = new SymptomsServices();
            LoadSymptoms();
        }
        private void LoadSymptoms()
        {
            List<string> symptoms = symptomsServices.GetSymptoms();

            foreach (string symptom in symptoms)
            {
                checkedListBox1.Items.Add((symptom));
            }

        }

        //private void CreateCheckBox(string symptomName, int yPosition)
        //{
        //    CheckBox checkBox = new CheckBox();
        //    checkBox.Text = symptomName;
        //    checkBox.Location = new System.Drawing.Point(10, yPosition);
        //    checkBox.AutoSize = true;
        //    this.Controls.Add(checkBox);
        //}


        // LA PARTE DIFICIL DEL CODIGO
        private void btnCheck_symptoms(object sender, EventArgs e)
        {
            lblResult.Text = "Resultados: ";

            List<int> selectedSymptomIds = new List<int>();

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                string symptom = checkedListBox1.Items[index].ToString().Trim();
                int symptomId = symptomsServices.GetSymptomIdByName(symptom);

                if (symptomId != 0)
                {
                    selectedSymptomIds.Add(symptomId);
                }

                if (!string.IsNullOrEmpty(lblResult.Text) && lblResult.Text != "Resultados: ")
                {
                    lblResult.Text += ", ";
                }
                lblResult.Text += symptom;
            }

            // Fetch the diagnostic results
            List<string> illnesses = symptomsServices.GetDiagnostic(selectedSymptomIds);

            if (illnesses.Count > 0)
            {
                // Construct the result string with percentages
                lblResult.Text = "Posibles enfermedades: " + string.Join(", ", illnesses);
            }
            else
            {
                lblResult.Text = "No se encontraron enfermedades coincidentes.";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
