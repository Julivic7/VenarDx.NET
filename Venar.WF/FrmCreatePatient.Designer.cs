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
            txtGenderPat = new TextBox();
            label8 = new Label();
            btnRegistar = new Button();
            txtMCovPat = new TextBox();
            txtLocaPat = new TextBox();
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
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(196, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(303, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 6;
            label1.Text = "REGISTRAR PACIENTE";
            // 
            // txtGenderPat
            // 
            txtGenderPat.BackColor = Color.WhiteSmoke;
            txtGenderPat.Location = new Point(704, 131);
            txtGenderPat.Name = "txtGenderPat";
            txtGenderPat.Size = new Size(288, 27);
            txtGenderPat.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(525, 270);
            label8.Name = "label8";
            label8.Size = new Size(154, 22);
            label8.TabIndex = 21;
            label8.Text = "OBRA SOCIAL:";
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(423, 353);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(256, 31);
            btnRegistar.TabIndex = 20;
            btnRegistar.Text = "REGISTRAR";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtMCovPat
            // 
            txtMCovPat.BackColor = Color.WhiteSmoke;
            txtMCovPat.Location = new Point(704, 268);
            txtMCovPat.Name = "txtMCovPat";
            txtMCovPat.Size = new Size(288, 27);
            txtMCovPat.TabIndex = 19;
            // 
            // txtLocaPat
            // 
            txtLocaPat.BackColor = Color.WhiteSmoke;
            txtLocaPat.Location = new Point(694, 201);
            txtLocaPat.Name = "txtLocaPat";
            txtLocaPat.Size = new Size(288, 27);
            txtLocaPat.TabIndex = 18;
            // 
            // txtDniPat
            // 
            txtDniPat.BackColor = Color.WhiteSmoke;
            txtDniPat.Location = new Point(162, 261);
            txtDniPat.Name = "txtDniPat";
            txtDniPat.Size = new Size(337, 27);
            txtDniPat.TabIndex = 16;
            // 
            // txtLastNamePat
            // 
            txtLastNamePat.BackColor = Color.WhiteSmoke;
            txtLastNamePat.Location = new Point(162, 196);
            txtLastNamePat.Name = "txtLastNamePat";
            txtLastNamePat.Size = new Size(337, 27);
            txtLastNamePat.TabIndex = 15;
            // 
            // txtNamePat
            // 
            txtNamePat.BackColor = Color.WhiteSmoke;
            txtNamePat.Location = new Point(162, 134);
            txtNamePat.Name = "txtNamePat";
            txtNamePat.Size = new Size(337, 27);
            txtNamePat.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(549, 201);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 13;
            label7.Text = "LOCALIDAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(585, 136);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 12;
            label6.Text = "GENERO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 305);
            label5.Name = "label5";
            label5.Size = new Size(178, 22);
            label5.TabIndex = 11;
            label5.Text = "FECHA DE NAC.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(50, 263);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 10;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 196);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 9;
            label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 139);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 8;
            label2.Text = "NOMBRE:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(465, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tempus Sans ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(710, 163);
            label9.Name = "label9";
            label9.Size = new Size(177, 17);
            label9.TabIndex = 26;
            label9.Text = "INGRESE 1 PARA FEMENINO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tempus Sans ITC", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(710, 180);
            label10.Name = "label10";
            label10.Size = new Size(186, 17);
            label10.TabIndex = 27;
            label10.Text = "INGRESE 2 PARA MASCULINO";
            // 
            // FrmCreatePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1036, 396);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtNamePat);
            Controls.Add(txtLastNamePat);
            Controls.Add(txtDniPat);
            Controls.Add(label3);
            Controls.Add(txtGenderPat);
            Controls.Add(label4);
            Controls.Add(btnRegistar);
            Controls.Add(txtLocaPat);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txtMCovPat);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCreatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtGenderPat;
        private Label label8;
        private Button btnRegistar;
        private TextBox txtMCovPat;
        private TextBox txtLocaPat;
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
        private Label label9;
        private Label label10;
    }
}