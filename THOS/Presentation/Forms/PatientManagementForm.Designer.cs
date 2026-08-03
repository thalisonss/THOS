namespace THOS.Forms
{
    partial class PatientManagementForm
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
            tbcPatients = new TabControl();
            tbpRegistration = new TabPage();
            tbpSearch = new TabPage();
            tbcPatients.SuspendLayout();
            SuspendLayout();
            // 
            // tbcPatients
            // 
            tbcPatients.Dock = DockStyle.Fill;
            tbcPatients.Controls.Add(tbpRegistration);
            tbcPatients.Controls.Add(tbpSearch);
            tbcPatients.Name = "tbcPatients";
            tbcPatients.SelectedIndex = 0;
            tbcPatients.Size = new Size(1096, 675);
            tbcPatients.TabIndex = 0;
            // 
            // tbpRegistration
            // 
            tbpRegistration.Name = "tbpRegistration";
            tbpRegistration.Padding = new Padding(3);
            tbpRegistration.AutoScroll = true;
            tbpRegistration.Size = new Size(1088, 642);
            tbpRegistration.TabIndex = 0;
            tbpRegistration.Text = "Cadastro";
            tbpRegistration.UseVisualStyleBackColor = true;
            // 
            // tbpSearch
            // 
            tbpSearch.Name = "tbpSearch";
            tbpSearch.Padding = new Padding(3);
            tbpSearch.AutoScroll = true;
            tbpSearch.Size = new Size(1088, 642);
            tbpSearch.TabIndex = 1;
            tbpSearch.Text = "Busca";
            tbpSearch.UseVisualStyleBackColor = true;
            // 
            // PatientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 675);
            Controls.Add(tbcPatients);
            MinimumSize = new Size(900, 600);
            Name = "PatientManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THOS | Pacientes";
            tbcPatients.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcPatients;
        private TabPage tbpRegistration;
        private TabPage tbpSearch;
    }
}
