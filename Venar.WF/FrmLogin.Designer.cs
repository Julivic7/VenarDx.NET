namespace Venar.WF
{
    partial class FrmLogin
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
            groupInicio = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            linkForgetPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            labelWelcome = new Label();
            groupInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupInicio
            // 
            groupInicio.AutoSize = true;
            groupInicio.BackColor = Color.MediumAquamarine;
            groupInicio.BackgroundImageLayout = ImageLayout.Center;
            groupInicio.Controls.Add(pictureBox2);
            groupInicio.Controls.Add(pictureBox1);
            groupInicio.Controls.Add(btnLogin);
            groupInicio.Controls.Add(linkForgetPassword);
            groupInicio.Controls.Add(txtPassword);
            groupInicio.Controls.Add(txtUser);
            groupInicio.Controls.Add(labelPassword);
            groupInicio.Controls.Add(labelUser);
            groupInicio.Controls.Add(labelWelcome);
            groupInicio.Dock = DockStyle.Fill;
            groupInicio.Location = new Point(0, 0);
            groupInicio.Margin = new Padding(3, 4, 3, 4);
            groupInicio.Name = "groupInicio";
            groupInicio.Padding = new Padding(3, 4, 3, 4);
            groupInicio.Size = new Size(1028, 620);
            groupInicio.TabIndex = 0;
            groupInicio.TabStop = false;
            groupInicio.Text = "Ingreso";
            groupInicio.Enter += groupInicio_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(997, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(414, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 108);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.BackgroundImage = Properties.Resources.acceso;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(519, 449);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(126, 53);
            btnLogin.TabIndex = 8;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.BackColor = Color.Transparent;
            linkForgetPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkForgetPassword.LinkColor = Color.Black;
            linkForgetPassword.Location = new Point(231, 477);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(189, 25);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Olvido su contraseña?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(378, 372);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.LightCyan;
            txtUser.Location = new Point(378, 309);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(267, 27);
            txtUser.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.ButtonFace;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(231, 372);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(114, 28);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.LightCyan;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ActiveCaptionText;
            labelUser.Location = new Point(231, 305);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(83, 28);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario:";
            labelUser.Click += labelUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Location = new Point(423, 227);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(160, 37);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Bienvenidos";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1028, 620);
            Controls.Add(groupInicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            groupInicio.ResumeLayout(false);
            groupInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupInicio;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkForgetPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelWelcome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}