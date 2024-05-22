namespace Venar.WF
{
    partial class FrmResetPassword
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
            label7 = new Label();
            btnConfirm = new Button();
            label6 = new Label();
            txtNewPassConfirm = new TextBox();
            txtNewPass = new TextBox();
            txtMailPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnConfirm);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNewPassConfirm);
            groupBox1.Controls.Add(txtNewPass);
            groupBox1.Controls.Add(txtMailPass);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(46, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reset Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 89);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.HotTrack;
            btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnConfirm.FlatAppearance.BorderSize = 10;
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(376, 291);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(138, 38);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 89);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // txtNewPassConfirm
            // 
            txtNewPassConfirm.Location = new Point(303, 234);
            txtNewPassConfirm.Name = "txtNewPassConfirm";
            txtNewPassConfirm.Size = new Size(211, 27);
            txtNewPassConfirm.TabIndex = 7;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(303, 193);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(211, 27);
            txtNewPass.TabIndex = 6;
            // 
            // txtMailPass
            // 
            txtMailPass.Location = new Point(303, 150);
            txtMailPass.Name = "txtMailPass";
            txtMailPass.Size = new Size(211, 27);
            txtMailPass.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(53, 89);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(53, 234);
            label4.Name = "label4";
            label4.Size = new Size(200, 20);
            label4.TabIndex = 3;
            label4.Text = "New Password confirmation: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(53, 193);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(53, 150);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Mail Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // FrmResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgForgPass;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(687, 503);
            Controls.Add(groupBox1);
            Name = "FrmResetPassword";
            Text = "FrmForgetPassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMailPass;
        private Label label6;
        private TextBox txtNewPassConfirm;
        private TextBox txtNewPass;
        private Button btnConfirm;
        private Label label7;
    }
}