namespace Venar.WF
{
    partial class FrmCreateMedic
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
            textBox1 = new TextBox();
            txtSpecialty = new TextBox();
            txtMedicalRegistration = new Label();
            label6 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtMail = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtDni = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(464, 208);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 23;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(464, 133);
            txtSpecialty.Margin = new Padding(3, 4, 3, 4);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(303, 27);
            txtSpecialty.TabIndex = 22;
            // 
            // txtMedicalRegistration
            // 
            txtMedicalRegistration.AutoSize = true;
            txtMedicalRegistration.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicalRegistration.Location = new Point(464, 184);
            txtMedicalRegistration.Name = "txtMedicalRegistration";
            txtMedicalRegistration.Size = new Size(189, 20);
            txtMedicalRegistration.TabIndex = 21;
            txtMedicalRegistration.Text = "Matricula Medica :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(464, 113);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 20;
            label6.Text = "Especialidad :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(464, 301);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(303, 27);
            txtUserName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(464, 277);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre de Usuario:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumAquamarine;
            btnRegister.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(580, 459);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 36);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(464, 387);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(303, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(62, 387);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(303, 27);
            txtMail.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 133);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 27);
            txtName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(62, 208);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(303, 27);
            txtLastName.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(62, 301);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(303, 27);
            txtDni.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(64, 109);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 7;
            label8.Text = "Nombre :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(464, 363);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 6;
            label7.Text = "Contraseña :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 363);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo Electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 277);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 2;
            label3.Text = "DNI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 175);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido :";
            // 
            // FrmCreateMedic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(882, 547);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtUserName);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtMedicalRegistration);
            Controls.Add(txtSpecialty);
            Controls.Add(label8);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCreateMedic";
            Text = "FrmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnRegister;
        private TextBox txtUserName;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtSpecialty;
        private Label txtMedicalRegistration;
        private Label label6;
    }
}