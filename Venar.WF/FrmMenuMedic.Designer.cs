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
            label7 = new Label();
            label4 = new Label();
            button1 = new Button();
            btnShowPatient = new Button();
            btnFinishSession = new Button();
            btnCreatePatient = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panelContenedor = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 237);
            label7.Name = "label7";
            label7.Size = new Size(179, 20);
            label7.TabIndex = 19;
            label7.Text = "Buscar  Pacientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 379);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 16;
            label4.Text = "Analizar Sintomas";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.BackgroundImage = Properties.Resources.analizar;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 403);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(209, 44);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnShowPatient
            // 
            btnShowPatient.BackColor = Color.Teal;
            btnShowPatient.BackgroundImage = Properties.Resources.optometrista;
            btnShowPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPatient.Cursor = Cursors.Hand;
            btnShowPatient.FlatAppearance.BorderSize = 0;
            btnShowPatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowPatient.FlatStyle = FlatStyle.Flat;
            btnShowPatient.Location = new Point(6, 282);
            btnShowPatient.Margin = new Padding(3, 4, 3, 4);
            btnShowPatient.Name = "btnShowPatient";
            btnShowPatient.Size = new Size(209, 44);
            btnShowPatient.TabIndex = 10;
            btnShowPatient.UseVisualStyleBackColor = false;
            btnShowPatient.Click += btnShowPatient_Click;
            // 
            // btnFinishSession
            // 
            btnFinishSession.BackColor = Color.Teal;
            btnFinishSession.Location = new Point(44, 477);
            btnFinishSession.Margin = new Padding(3, 4, 3, 4);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(115, 29);
            btnFinishSession.TabIndex = 9;
            btnFinishSession.Text = "Cerrar Sesion";
            btnFinishSession.UseVisualStyleBackColor = false;
            btnFinishSession.Click += btnFinishSession_Click;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.BackColor = Color.Teal;
            btnCreatePatient.BackgroundImage = Properties.Resources.paciente;
            btnCreatePatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePatient.Cursor = Cursors.Hand;
            btnCreatePatient.FlatAppearance.BorderSize = 0;
            btnCreatePatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePatient.FlatStyle = FlatStyle.Flat;
            btnCreatePatient.Location = new Point(9, 161);
            btnCreatePatient.Margin = new Padding(3, 4, 3, 4);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(209, 41);
            btnCreatePatient.TabIndex = 5;
            btnCreatePatient.UseVisualStyleBackColor = false;
            btnCreatePatient.Click += btnCreatePatient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "MEDICO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnFinishSession);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreatePatient);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnShowPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 524);
            panel1.TabIndex = 20;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(221, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1022, 524);
            panelContenedor.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 120);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 14;
            label2.Text = "Nuevo Paciente";
            // 
            // FrmMenuMedic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1243, 524);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuMedic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuMedic";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnShowPatient;
        private Button btnFinishSession;
        private Button btnCreatePatient;
        private Label label1;
        private Button button1;
        private Label label7;
        private Label label4;
        private Panel panel1;
        private Panel panelContenedor;
        private Label label2;
    }
}