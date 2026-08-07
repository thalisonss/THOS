namespace THOS.Client.Presentation.Controls
{
    partial class PacienteControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tbcPatients;
        private System.Windows.Forms.TabPage tbpRegistration;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.Panel pnlTabButtons;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbcPatients = new TabControl();
            tbpRegistration = new TabPage();
            tbpSearch = new TabPage();
            pnlTabButtons = new Panel();
            btnConsultar = new Button();
            btnCadastrar = new Button();
            tbcPatients.SuspendLayout();
            pnlTabButtons.SuspendLayout();
            SuspendLayout();

            tbcPatients.Controls.Add(tbpRegistration);
            tbcPatients.Controls.Add(tbpSearch);
            tbcPatients.Dock = DockStyle.Fill;
            tbcPatients.Location = new Point(0, 45);
            tbcPatients.Name = "tbcPatients";
            tbcPatients.SelectedIndex = 1;
            tbcPatients.Size = new Size(1110, 695);
            tbcPatients.TabIndex = 1;

            tbpRegistration.Name = "tbpRegistration";
            tbpRegistration.Padding = new Padding(3);
            tbpRegistration.Size = new Size(1102, 673);
            tbpRegistration.TabIndex = 0;
            tbpRegistration.Text = "Cadastrar";
            tbpRegistration.UseVisualStyleBackColor = true;

            tbpSearch.Name = "tbpSearch";
            tbpSearch.Padding = new Padding(3);
            tbpSearch.Size = new Size(1102, 673);
            tbpSearch.TabIndex = 1;
            tbpSearch.Text = "Consultar";
            tbpSearch.UseVisualStyleBackColor = true;

            pnlTabButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            pnlTabButtons.Controls.Add(btnConsultar);
            pnlTabButtons.Controls.Add(btnCadastrar);
            pnlTabButtons.Dock = DockStyle.Top;
            pnlTabButtons.Location = new Point(0, 0);
            pnlTabButtons.Name = "pnlTabButtons";
            pnlTabButtons.Size = new Size(1110, 45);
            pnlTabButtons.TabIndex = 0;

            btnConsultar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnConsultar.ForeColor = System.Drawing.Color.White;
            btnConsultar.Location = new Point(10, 8);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 30);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += BtnConsultar_Click;

            btnCadastrar.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnCadastrar.ForeColor = System.Drawing.Color.White;
            btnCadastrar.Location = new Point(120, 8);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 30);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += BtnCadastrar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcPatients);
            Controls.Add(pnlTabButtons);
            Name = "PacienteControl";
            Size = new System.Drawing.Size(1110, 740);
            tbcPatients.ResumeLayout(false);
            pnlTabButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnConsultar_Click(object? sender, EventArgs e) => tbcPatients.SelectedTab = tbpSearch;
        private void BtnCadastrar_Click(object? sender, EventArgs e) => tbcPatients.SelectedTab = tbpRegistration;
    }
}
