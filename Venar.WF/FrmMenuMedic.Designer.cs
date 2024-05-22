namespace Venar.WF
{
    partial class FrmMenuMedic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnModifyPatient = new Button();
            btnDeleatPatient = new Button();
            btnShowPatient = new Button();
            btnFinishSession = new Button();
            btnCreatePatient = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BackgroundImage = Properties.Resources.allLayers1;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnModifyPatient);
            groupBox1.Controls.Add(btnDeleatPatient);
            groupBox1.Controls.Add(btnShowPatient);
            groupBox1.Controls.Add(btnFinishSession);
            groupBox1.Controls.Add(btnCreatePatient);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(91, 50);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(449, 593);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medic Main";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.analizar;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(63, 410);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 56);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnModifyPatient
            // 
            btnModifyPatient.BackColor = Color.Transparent;
            btnModifyPatient.BackgroundImage = Properties.Resources.edicion_de_usuario;
            btnModifyPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifyPatient.Cursor = Cursors.Hand;
            btnModifyPatient.Location = new Point(63, 284);
            btnModifyPatient.Margin = new Padding(3, 4, 3, 4);
            btnModifyPatient.Name = "btnModifyPatient";
            btnModifyPatient.Size = new Size(90, 56);
            btnModifyPatient.TabIndex = 12;
            btnModifyPatient.UseVisualStyleBackColor = false;
            // 
            // btnDeleatPatient
            // 
            btnDeleatPatient.BackColor = Color.Transparent;
            btnDeleatPatient.BackgroundImage = Properties.Resources.eliminarPaciente;
            btnDeleatPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleatPatient.Cursor = Cursors.Hand;
            btnDeleatPatient.Location = new Point(277, 284);
            btnDeleatPatient.Margin = new Padding(3, 4, 3, 4);
            btnDeleatPatient.Name = "btnDeleatPatient";
            btnDeleatPatient.Size = new Size(90, 56);
            btnDeleatPatient.TabIndex = 11;
            btnDeleatPatient.UseVisualStyleBackColor = false;
            // 
            // btnShowPatient
            // 
            btnShowPatient.BackColor = Color.Transparent;
            btnShowPatient.BackgroundImage = Properties.Resources.optometrista;
            btnShowPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPatient.Cursor = Cursors.Hand;
            btnShowPatient.Location = new Point(277, 152);
            btnShowPatient.Margin = new Padding(3, 4, 3, 4);
            btnShowPatient.Name = "btnShowPatient";
            btnShowPatient.Size = new Size(90, 56);
            btnShowPatient.TabIndex = 10;
            btnShowPatient.UseVisualStyleBackColor = false;
            // 
            // btnFinishSession
            // 
            btnFinishSession.Location = new Point(277, 506);
            btnFinishSession.Margin = new Padding(3, 4, 3, 4);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(115, 29);
            btnFinishSession.TabIndex = 9;
            btnFinishSession.Text = "Cerrar Sesion";
            btnFinishSession.UseVisualStyleBackColor = true;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.BackColor = Color.Transparent;
            btnCreatePatient.BackgroundImage = Properties.Resources.paciente;
            btnCreatePatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePatient.Cursor = Cursors.Hand;
            btnCreatePatient.Location = new Point(63, 152);
            btnCreatePatient.Margin = new Padding(3, 4, 3, 4);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(90, 56);
            btnCreatePatient.TabIndex = 5;
            btnCreatePatient.UseVisualStyleBackColor = false;
            btnCreatePatient.Click += btnCreatePatient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Medico: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(63, 119);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 14;
            label2.Text = "Nuevo Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(63, 364);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 16;
            label4.Text = "Analizar Sintomas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(63, 243);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 17;
            label5.Text = "Modificar Pacientes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(256, 243);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 18;
            label6.Text = "Eliminar Paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(256, 119);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 19;
            label7.Text = "Ver Pacientes";
            // 
            // FrmMenuMedic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 703);
            Controls.Add(groupBox1);
            Name = "FrmMenuMedic";
            Text = "FrmMenuMedic";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnModifyPatient;
        private Button btnDeleatPatient;
        private Button btnShowPatient;
        private Button btnFinishSession;
        private Button btnCreatePatient;
        private Label label1;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}