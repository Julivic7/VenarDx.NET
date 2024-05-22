namespace Venar.WF
{
    partial class FrmForgetPassword
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
            SendMail = new GroupBox();
            txtMail = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            SendMail.SuspendLayout();
            SuspendLayout();
            // 
            // SendMail
            // 
            SendMail.BackColor = Color.Transparent;
            SendMail.Controls.Add(txtMail);
            SendMail.Controls.Add(label1);
            SendMail.Controls.Add(btnAceptar);
            SendMail.ForeColor = SystemColors.ButtonHighlight;
            SendMail.Location = new Point(25, 93);
            SendMail.Name = "SendMail";
            SendMail.Size = new Size(549, 321);
            SendMail.TabIndex = 0;
            SendMail.TabStop = false;
            SendMail.Text = "Forget Password";
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.ForeColor = SystemColors.ControlText;
            txtMail.Location = new Point(106, 160);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(295, 27);
            txtMail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(106, 110);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "INGRESE SU MAIL";
            label1.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.HotTrack;
            btnAceptar.ForeColor = SystemColors.HighlightText;
            btnAceptar.Location = new Point(284, 215);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 36);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgForgPass;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(599, 514);
            Controls.Add(SendMail);
            Name = "FrmForgetPassword";
            Text = "FrmForgetPassword";
            SendMail.ResumeLayout(false);
            SendMail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SendMail;
        private Label label1;
        private Button btnAceptar;
        private TextBox txtMail;
    }
}