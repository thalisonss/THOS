using System;
using System.Windows.Forms;
using THOS.Client.Presentation.Controls;
using THOS.Client.Domain.Entities;

namespace THOS.Client.Presentation.Controls
{
    public partial class UsuarioControl : UserControl
    {
        private UserSearchControl _searchControl = null!;
        private UserRegistrationControl _registrationControl = null!;

        public UsuarioControl()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeComponent()
        {
            tbcUsuarios = new TabControl();
            tbpSearch = new TabPage();
            tbpRegistration = new TabPage();
            pnlTabButtons = new Panel();
            btnConsultar = new Button();
            btnCadastrar = new Button();
            tbcUsuarios.SuspendLayout();
            pnlTabButtons.SuspendLayout();
            SuspendLayout();

            tbcUsuarios.Controls.Add(tbpSearch);
            tbcUsuarios.Controls.Add(tbpRegistration);
            tbcUsuarios.Dock = DockStyle.Fill;
            tbcUsuarios.Location = new Point(0, 45);
            tbcUsuarios.Name = "tbcUsuarios";
            tbcUsuarios.SelectedIndex = 0;
            tbcUsuarios.Size = new Size(1110, 695);
            tbcUsuarios.TabIndex = 1;
            tbcUsuarios.ItemSize = new Size(0, 1);
            tbcUsuarios.SizeMode = TabSizeMode.Fixed;
            tbcUsuarios.Appearance = TabAppearance.Buttons;

            tbpSearch.Name = "tbpSearch";
            tbpSearch.Padding = new Padding(3);
            tbpSearch.Size = new Size(1102, 673);
            tbpSearch.TabIndex = 0;
            tbpSearch.Text = "Consultar";
            tbpSearch.UseVisualStyleBackColor = true;

            tbpRegistration.Name = "tbpRegistration";
            tbpRegistration.Padding = new Padding(3);
            tbpRegistration.Size = new Size(1102, 673);
            tbpRegistration.TabIndex = 1;
            tbpRegistration.Text = "Cadastrar";
            tbpRegistration.UseVisualStyleBackColor = true;

            pnlTabButtons.BackColor = Color.FromArgb(236, 240, 241);
            pnlTabButtons.Controls.Add(btnConsultar);
            pnlTabButtons.Controls.Add(btnCadastrar);
            pnlTabButtons.Dock = DockStyle.Top;
            pnlTabButtons.Location = new Point(0, 0);
            pnlTabButtons.Name = "pnlTabButtons";
            pnlTabButtons.Size = new Size(1110, 45);
            pnlTabButtons.TabIndex = 0;

            btnConsultar.BackColor = Color.FromArgb(52, 152, 219);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(10, 8);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 30);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += (s, e) => tbcUsuarios.SelectedTab = tbpSearch;

            btnCadastrar.BackColor = Color.FromArgb(149, 165, 166);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 10F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(120, 8);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 30);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += (s, e) => tbcUsuarios.SelectedTab = tbpRegistration;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcUsuarios);
            Controls.Add(pnlTabButtons);
            Name = "UsuarioControl";
            Size = new Size(1110, 740);
            tbcUsuarios.ResumeLayout(false);
            pnlTabButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabControl tbcUsuarios = null!;
        private TabPage tbpSearch = null!;
        private TabPage tbpRegistration = null!;
        private Panel pnlTabButtons = null!;
        private Button btnConsultar = null!;
        private Button btnCadastrar = null!;

        private void InitializeControls()
        {
            _searchControl = new UserSearchControl { Dock = DockStyle.Fill };
            _searchControl.OnUserSelectedForEdit += SearchControl_OnUserSelectedForEdit;
            tbpSearch.Controls.Clear();
            tbpSearch.Controls.Add(_searchControl);

            _registrationControl = new UserRegistrationControl { Dock = DockStyle.Fill };
            _registrationControl.OnCancelled += (s, e) => SwitchToSearchTab();
            _registrationControl.OnSaved += (s, e) => SwitchToSearchTab();
            tbpRegistration.Controls.Clear();
            tbpRegistration.Controls.Add(_registrationControl);

            _searchControl.LoadUsers();
        }

        private void SearchControl_OnUserSelectedForEdit(object? sender, (LocalUser User, System.Collections.Generic.List<LocalProfile> AssignedProfiles) e)
        {
            _registrationControl.LoadUser(e.User, e.AssignedProfiles);
            tbcUsuarios.SelectedTab = tbpRegistration;
        }

        private void SwitchToSearchTab()
        {
            _searchControl.LoadUsers();
            tbcUsuarios.SelectedTab = tbpSearch;
        }
    }
}
