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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            groupInicio = new GroupBox();
            btnLogin = new Button();
            linkForgetPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            labelWelcome = new Label();
            groupInicio.SuspendLayout();
            SuspendLayout();
            // 
            // groupInicio
            // 
            groupInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupInicio.AutoSize = true;
            groupInicio.BackColor = Color.Transparent;
            groupInicio.BackgroundImage = (Image)resources.GetObject("groupInicio.BackgroundImage");
            groupInicio.Controls.Add(btnLogin);
            groupInicio.Controls.Add(linkForgetPassword);
            groupInicio.Controls.Add(txtPassword);
            groupInicio.Controls.Add(txtUser);
            groupInicio.Controls.Add(labelPassword);
            groupInicio.Controls.Add(labelUser);
            groupInicio.Controls.Add(labelWelcome);
            groupInicio.Location = new Point(12, 13);
            groupInicio.Margin = new Padding(3, 4, 3, 4);
            groupInicio.Name = "groupInicio";
            groupInicio.Padding = new Padding(3, 4, 3, 4);
            groupInicio.Size = new Size(758, 693);
            groupInicio.TabIndex = 0;
            groupInicio.TabStop = false;
            groupInicio.Text = "Inicio";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.acceso;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(426, 549);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(95, 52);
            btnLogin.TabIndex = 8;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.BackColor = Color.Transparent;
            linkForgetPassword.Location = new Point(167, 565);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(154, 20);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Olvido su contraseña?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 495);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(300, 425);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(221, 27);
            txtUser.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(167, 494);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(114, 28);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.Location = new Point(169, 424);
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
            labelWelcome.Location = new Point(300, 131);
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
            ClientSize = new Size(771, 748);
            Controls.Add(groupInicio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            Text = "FrmLogin";
            groupInicio.ResumeLayout(false);
            groupInicio.PerformLayout();
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
    }
}