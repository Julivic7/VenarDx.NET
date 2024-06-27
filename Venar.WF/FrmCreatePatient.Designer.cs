namespace Venar.WF
{
    partial class FrmCreatePatient
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label8 = new Label();
            btnRegistar = new Button();
            txtDniPat = new TextBox();
            txtLastNamePat = new TextBox();
            txtNamePat = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            cmbLocations = new ComboBox();
            cmbCoverMed = new ComboBox();
            cmbGenders = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(172, 229);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 6;
            label1.Text = "REGISTRAR PACIENTE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(459, 202);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 21;
            label8.Text = "OBRA SOCIAL:";
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(370, 265);
            btnRegistar.Margin = new Padding(3, 2, 3, 2);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(224, 23);
            btnRegistar.TabIndex = 20;
            btnRegistar.Text = "REGISTRAR";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtDniPat
            // 
            txtDniPat.BackColor = Color.WhiteSmoke;
            txtDniPat.Location = new Point(142, 196);
            txtDniPat.Margin = new Padding(3, 2, 3, 2);
            txtDniPat.Name = "txtDniPat";
            txtDniPat.Size = new Size(295, 23);
            txtDniPat.TabIndex = 16;
            // 
            // txtLastNamePat
            // 
            txtLastNamePat.BackColor = Color.WhiteSmoke;
            txtLastNamePat.Location = new Point(142, 147);
            txtLastNamePat.Margin = new Padding(3, 2, 3, 2);
            txtLastNamePat.Name = "txtLastNamePat";
            txtLastNamePat.Size = new Size(295, 23);
            txtLastNamePat.TabIndex = 15;
            // 
            // txtNamePat
            // 
            txtNamePat.BackColor = Color.WhiteSmoke;
            txtNamePat.Location = new Point(142, 100);
            txtNamePat.Margin = new Padding(3, 2, 3, 2);
            txtNamePat.Name = "txtNamePat";
            txtNamePat.Size = new Size(295, 23);
            txtNamePat.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(480, 151);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 13;
            label7.Text = "LOCALIDAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(512, 102);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 12;
            label6.Text = "GENERO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 229);
            label5.Name = "label5";
            label5.Size = new Size(148, 18);
            label5.TabIndex = 11;
            label5.Text = "FECHA DE NAC.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(44, 197);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 10;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 147);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 9;
            label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 8;
            label2.Text = "NOMBRE:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(407, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tempus Sans ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(621, 135);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 27;
            // 
            // cmbLocations
            // 
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(607, 153);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(234, 23);
            cmbLocations.TabIndex = 28;
            // 
            // cmbCoverMed
            // 
            cmbCoverMed.FormattingEnabled = true;
            cmbCoverMed.Location = new Point(607, 196);
            cmbCoverMed.Name = "cmbCoverMed";
            cmbCoverMed.Size = new Size(234, 23);
            cmbCoverMed.TabIndex = 30;
            // 
            // cmbGenders
            // 
            cmbGenders.FormattingEnabled = true;
            cmbGenders.Location = new Point(607, 97);
            cmbGenders.Name = "cmbGenders";
            cmbGenders.Size = new Size(234, 23);
            cmbGenders.TabIndex = 31;
            // 
            // FrmCreatePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(906, 297);
            Controls.Add(cmbGenders);
            Controls.Add(cmbCoverMed);
            Controls.Add(cmbLocations);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtNamePat);
            Controls.Add(txtLastNamePat);
            Controls.Add(txtDniPat);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnRegistar);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCreatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label8;
        private Button btnRegistar;
        private TextBox txtDniPat;
        private TextBox txtLastNamePat;
        private TextBox txtNamePat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label10;
        private ComboBox cmbLocations;
      
        private ComboBox cmbCoverMed;
        private ComboBox cmbGenders;
    }
}