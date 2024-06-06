﻿namespace Venar.WF
{
    partial class FrmMenuAdmin
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
            btnCreateMedic = new Button();
            btnShowMedic = new Button();
            btnDeleatMedic = new Button();
            btnModifyMedic = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            PnlControlBtns = new Panel();
            button1 = new Button();
            panelContenedor = new Panel();
            label1 = new Label();
            PnlControlBtns.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.BackColor = Color.Teal;
            btnCreateMedic.BackgroundImage = Properties.Resources.agregar_usuario;
            btnCreateMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreateMedic.Cursor = Cursors.Hand;
            btnCreateMedic.FlatAppearance.BorderSize = 0;
            btnCreateMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateMedic.FlatStyle = FlatStyle.Flat;
            btnCreateMedic.ImageAlign = ContentAlignment.TopLeft;
            btnCreateMedic.Location = new Point(3, 79);
            btnCreateMedic.Margin = new Padding(3, 4, 3, 4);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(215, 57);
            btnCreateMedic.TabIndex = 5;
            btnCreateMedic.TextAlign = ContentAlignment.BottomCenter;
            btnCreateMedic.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCreateMedic.UseVisualStyleBackColor = false;
            btnCreateMedic.Click += btnCreateMedic_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.BackColor = Color.Teal;
            btnShowMedic.BackgroundImage = Properties.Resources.ver;
            btnShowMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowMedic.FlatAppearance.BorderSize = 0;
            btnShowMedic.FlatAppearance.MouseDownBackColor = Color.White;
            btnShowMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowMedic.FlatStyle = FlatStyle.Flat;
            btnShowMedic.Location = new Point(3, 173);
            btnShowMedic.Margin = new Padding(3, 4, 3, 4);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(215, 52);
            btnShowMedic.TabIndex = 10;
            btnShowMedic.UseVisualStyleBackColor = false;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.BackColor = Color.Teal;
            btnDeleatMedic.BackgroundImage = Properties.Resources.borrar_usuario;
            btnDeleatMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleatMedic.FlatAppearance.BorderSize = 0;
            btnDeleatMedic.FlatAppearance.MouseDownBackColor = Color.White;
            btnDeleatMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnDeleatMedic.FlatStyle = FlatStyle.Flat;
            btnDeleatMedic.Location = new Point(3, 366);
            btnDeleatMedic.Margin = new Padding(3, 4, 3, 4);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(215, 54);
            btnDeleatMedic.TabIndex = 11;
            btnDeleatMedic.UseVisualStyleBackColor = false;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.BackColor = Color.Teal;
            btnModifyMedic.BackgroundImage = Properties.Resources.edicion_de_usuario;
            btnModifyMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifyMedic.FlatAppearance.BorderSize = 0;
            btnModifyMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnModifyMedic.FlatStyle = FlatStyle.Flat;
            btnModifyMedic.ForeColor = SystemColors.ControlLight;
            btnModifyMedic.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifyMedic.Location = new Point(6, 257);
            btnModifyMedic.Margin = new Padding(3, 4, 3, 4);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(215, 58);
            btnModifyMedic.TabIndex = 12;
            btnModifyMedic.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 13;
            label2.Text = "Crear Medico";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 334);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 14;
            label3.Text = "Eliminar Medico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 234);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 15;
            label4.Text = "Modificar Medico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 150);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 16;
            label5.Text = "Ver Medico";
            // 
            // PnlControlBtns
            // 
            PnlControlBtns.BackColor = Color.Teal;
            PnlControlBtns.Controls.Add(button1);
            PnlControlBtns.Controls.Add(btnCreateMedic);
            PnlControlBtns.Controls.Add(label2);
            PnlControlBtns.Controls.Add(label3);
            PnlControlBtns.Controls.Add(label4);
            PnlControlBtns.Controls.Add(btnShowMedic);
            PnlControlBtns.Controls.Add(label5);
            PnlControlBtns.Controls.Add(btnModifyMedic);
            PnlControlBtns.Controls.Add(btnDeleatMedic);
            PnlControlBtns.Dock = DockStyle.Left;
            PnlControlBtns.Location = new Point(0, 0);
            PnlControlBtns.Name = "PnlControlBtns";
            PnlControlBtns.Size = new Size(221, 595);
            PnlControlBtns.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(40, 543);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 18;
            button1.Text = "cerrar sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(221, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(855, 595);
            panelContenedor.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRADOR";
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1076, 595);
            Controls.Add(panelContenedor);
            Controls.Add(PnlControlBtns);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenuAdmin";
            Text = "FrmMenuAdmin";
            PnlControlBtns.ResumeLayout(false);
            PnlControlBtns.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateMedic;
        private Button btnShowMedic;
        private Button btnDeleatMedic;
        private Button btnModifyMedic;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel PnlControlBtns;
        private Button button1;
        private Panel panelContenedor;
        private Label label1;
    }
}