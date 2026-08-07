namespace THOS.Client.Presentation.Controls
{
    partial class UserRegistrationControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        
        private System.Windows.Forms.GroupBox grpProfiles;
        private System.Windows.Forms.TextBox txtSearchProfile;
        private System.Windows.Forms.Label lblSearchProfile;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfileName;
        
        private System.Windows.Forms.Button btnSave;

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
            lblTitle = new System.Windows.Forms.Label();
            grpUser = new System.Windows.Forms.GroupBox();
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblLogin = new System.Windows.Forms.Label();
            txtLogin = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            
            grpProfiles = new System.Windows.Forms.GroupBox();
            lblSearchProfile = new System.Windows.Forms.Label();
            txtSearchProfile = new System.Windows.Forms.TextBox();
            dgvProfiles = new System.Windows.Forms.DataGridView();
            colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colProfileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnSave = new System.Windows.Forms.Button();
            
            grpUser.SuspendLayout();
            grpProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvProfiles)).BeginInit();
            SuspendLayout();
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblTitle.Location = new System.Drawing.Point(10, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Cadastro de Usuários";
            
            // grpUser
            grpUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpUser.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            grpUser.Controls.Add(txtPassword);
            grpUser.Controls.Add(lblPassword);
            grpUser.Controls.Add(txtLogin);
            grpUser.Controls.Add(lblLogin);
            grpUser.Controls.Add(txtFullName);
            grpUser.Controls.Add(lblFullName);
            grpUser.Location = new System.Drawing.Point(15, 55);
            grpUser.Name = "grpUser";
            grpUser.Size = new System.Drawing.Size(330, 240);
            grpUser.TabStop = false;
            grpUser.Text = "Dados do Usuário";
            
            // lblFullName
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblFullName.Location = new System.Drawing.Point(15, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Text = "Nome Completo *";
            // txtFullName
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtFullName.Location = new System.Drawing.Point(15, 50);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(295, 25);
            
            // lblLogin
            lblLogin.AutoSize = true;
            lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLogin.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblLogin.Location = new System.Drawing.Point(15, 90);
            lblLogin.Name = "lblLogin";
            lblLogin.Text = "Login *";
            // txtLogin
            txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtLogin.Location = new System.Drawing.Point(15, 110);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(295, 25);
            
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblPassword.Location = new System.Drawing.Point(15, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Senha *";
            // txtPassword
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPassword.Location = new System.Drawing.Point(15, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(295, 25);
            txtPassword.UseSystemPasswordChar = true;
            
            // grpProfiles
            grpProfiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpProfiles.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            grpProfiles.Controls.Add(dgvProfiles);
            grpProfiles.Controls.Add(txtSearchProfile);
            grpProfiles.Controls.Add(lblSearchProfile);
            grpProfiles.Location = new System.Drawing.Point(365, 55);
            grpProfiles.Name = "grpProfiles";
            grpProfiles.Size = new System.Drawing.Size(370, 240);
            grpProfiles.TabStop = false;
            grpProfiles.Text = "Perfis de Acesso";
            
            // lblSearchProfile
            lblSearchProfile.AutoSize = true;
            lblSearchProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchProfile.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblSearchProfile.Location = new System.Drawing.Point(15, 30);
            lblSearchProfile.Name = "lblSearchProfile";
            lblSearchProfile.Text = "Pesquisar:";
            // txtSearchProfile
            txtSearchProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearchProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearchProfile.Location = new System.Drawing.Point(85, 27);
            txtSearchProfile.Name = "txtSearchProfile";
            txtSearchProfile.Size = new System.Drawing.Size(265, 25);
            txtSearchProfile.TextChanged += txtSearchProfile_TextChanged;
            
            // dgvProfiles
            dgvProfiles.AllowUserToAddRows = false;
            dgvProfiles.AllowUserToDeleteRows = false;
            dgvProfiles.BackgroundColor = System.Drawing.Color.White;
            dgvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCheck, colProfileId, colProfileName });
            dgvProfiles.Location = new System.Drawing.Point(15, 60);
            dgvProfiles.Name = "dgvProfiles";
            dgvProfiles.RowHeadersVisible = false;
            dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProfiles.Size = new System.Drawing.Size(335, 165);
            dgvProfiles.GridColor = System.Drawing.Color.FromArgb(228, 228, 228);
            
            // colCheck
            colCheck.HeaderText = "";
            colCheck.Name = "colCheck";
            colCheck.Width = 35;
            // colProfileId
            colProfileId.HeaderText = "ID";
            colProfileId.Name = "colProfileId";
            colProfileId.Visible = false;
            // colProfileName
            colProfileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colProfileName.HeaderText = "Perfil";
            colProfileName.Name = "colProfileName";
            colProfileName.ReadOnly = true;
            
            // btnSave
            btnSave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(605, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(130, 38);
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            // UserRegistrationControl
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(btnSave);
            Controls.Add(grpProfiles);
            Controls.Add(grpUser);
            Controls.Add(lblTitle);
            Name = "UserRegistrationControl";
            Size = new System.Drawing.Size(760, 375);
            Load += UserRegistrationControl_Load;
            
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            grpProfiles.ResumeLayout(false);
            grpProfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvProfiles)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}