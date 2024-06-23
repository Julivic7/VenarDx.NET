using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmViewPatients : Form

    {
        PatientsSVC patientsSVC;
     
        public FrmViewPatients()
        {
            InitializeComponent();
            patientsSVC = new PatientsSVC();
            
           

        }
        private void button2_Click(object sender, EventArgs e)

        {
            int dni;
            if (!int.TryParse(txtBxDniSearch.Text, out dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");

            }
            datagridPatients.Columns.Clear();
            datagridPatients.Rows.Clear();


            datagridPatients.DataSource = patientsSVC.SearchPat(dni);
            var pat = patientsSVC.SearchPat(dni);
            ; }

                


            
        

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
           

        //    bool update = patientsSVC.UpdatePatient();

          //  if (update)
            //{
              //  MessageBox.Show("Datos del paciente actualizados exitosamente.");

                //datagridPatients.Columns.Clear();
                //datagridPatients.Rows.Clear();

                //var pat = patientsSVC.SearchPat(dni);


                //datagridPatients.Columns.Add("NameColumn", "Nombre");
                //datagridPatients.Columns.Add("LastNameColumn", "Apellido");
                //datagridPatients.Columns.Add("CoverColumn", "Cover");


                //if (pat != null)
                //{

                  //  datagridPatients.Rows.Add(
                    //     pat.nombre,
                      //   pat.apellido,
                        // pat.obraSocialPaciente
                   // );
               // }
               // else

                 //   MessageBox.Show("Error al actualizar los datos del paciente.");



            }
        }
    }

        
    


