namespace Venar.WF
{
    partial class FrmSymptoms
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
        private System.Windows.Forms.Button btnCheckSymptoms;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            btnCheckSymptoms = new Button();
            lblResult = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // btnCheckSymptoms
            // 
            btnCheckSymptoms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckSymptoms.Location = new Point(12, 190);
            btnCheckSymptoms.Name = "btnCheckSymptoms";
            btnCheckSymptoms.Size = new Size(75, 30);
            btnCheckSymptoms.TabIndex = 3;
            btnCheckSymptoms.TabStop = false;
            btnCheckSymptoms.Text = "Enviar";
            btnCheckSymptoms.UseVisualStyleBackColor = true;
            btnCheckSymptoms.Click += btnCheck_symptoms;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.Location = new Point(93, 198);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(64, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Resultados";
            lblResult.Click += lblResult_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(498, 166);
            checkedListBox1.TabIndex = 5;
            // 
            // FrmSymptoms
            // 
            ClientSize = new Size(522, 232);
            Controls.Add(btnCheckSymptoms);
            Controls.Add(lblResult);
            Controls.Add(checkedListBox1);
            Name = "FrmSymptoms";
            Text = "Symptom Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
    }
}