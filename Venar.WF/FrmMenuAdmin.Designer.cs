namespace Venar.WF
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnModifyMedic = new Button();
            btnDeleatMedic = new Button();
            btnShowMedic = new Button();
            btnFinishSesion = new Button();
            btnCreateMedic = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.allLayers;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnModifyMedic);
            groupBox1.Controls.Add(btnDeleatMedic);
            groupBox1.Controls.Add(btnShowMedic);
            groupBox1.Controls.Add(btnFinishSesion);
            groupBox1.Controls.Add(btnCreateMedic);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(481, 619);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Main";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(284, 147);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 16;
            label5.Text = "Ver Medico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 338);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 15;
            label4.Text = "Modificar Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 338);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 14;
            label3.Text = "Eliminar Medico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 147);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 13;
            label2.Text = "Crear Medico";
            label2.Click += label2_Click;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.BackColor = Color.Transparent;
            btnModifyMedic.BackgroundImage = Properties.Resources.edicion_de_usuario;
            btnModifyMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifyMedic.ForeColor = SystemColors.ControlLight;
            btnModifyMedic.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifyMedic.Location = new Point(77, 373);
            btnModifyMedic.Margin = new Padding(3, 4, 3, 4);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(115, 68);
            btnModifyMedic.TabIndex = 12;
            btnModifyMedic.UseVisualStyleBackColor = false;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.BackColor = Color.Transparent;
            btnDeleatMedic.BackgroundImage = Properties.Resources.borrar_usuario;
            btnDeleatMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleatMedic.Location = new Point(284, 373);
            btnDeleatMedic.Margin = new Padding(3, 4, 3, 4);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(115, 68);
            btnDeleatMedic.TabIndex = 11;
            btnDeleatMedic.UseVisualStyleBackColor = false;
            // 
            // btnShowMedic
            // 
            btnShowMedic.BackColor = Color.Transparent;
            btnShowMedic.BackgroundImage = Properties.Resources.ver;
            btnShowMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowMedic.Location = new Point(290, 179);
            btnShowMedic.Margin = new Padding(3, 4, 3, 4);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(115, 64);
            btnShowMedic.TabIndex = 10;
            btnShowMedic.UseVisualStyleBackColor = false;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // btnFinishSesion
            // 
            btnFinishSesion.Location = new Point(290, 531);
            btnFinishSesion.Margin = new Padding(3, 4, 3, 4);
            btnFinishSesion.Name = "btnFinishSesion";
            btnFinishSesion.Size = new Size(115, 29);
            btnFinishSesion.TabIndex = 9;
            btnFinishSesion.Text = "Cerrar Sesion";
            btnFinishSesion.UseVisualStyleBackColor = true;
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.BackColor = Color.Transparent;
            btnCreateMedic.BackgroundImage = Properties.Resources.agregar_usuario;
            btnCreateMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreateMedic.Cursor = Cursors.Hand;
            btnCreateMedic.ImageAlign = ContentAlignment.TopRight;
            btnCreateMedic.Location = new Point(77, 179);
            btnCreateMedic.Margin = new Padding(3, 4, 3, 4);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(115, 64);
            btnCreateMedic.TabIndex = 5;
            btnCreateMedic.TextAlign = ContentAlignment.BottomCenter;
            btnCreateMedic.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCreateMedic.UseVisualStyleBackColor = false;
            btnCreateMedic.Click += btnCreateMedic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Administrador";
            label1.Click += label1_Click;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 648);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenuAdmin";
            Text = "FrmMenuAdmin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinishSesion;
        private System.Windows.Forms.Button btnCreateMedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyMedic;
        private System.Windows.Forms.Button btnDeleatMedic;
        private System.Windows.Forms.Button btnShowMedic;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}