namespace THOS.Client.Presentation.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnChangeProfile;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtMenuSearch;
        private System.Windows.Forms.Panel pnlSearchBar;

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
            pnlSidebar = new Panel();
            pnlSearchBar = new Panel();
            txtMenuSearch = new TextBox();
            lblLogo = new Label();
            pnlHeader = new Panel();
            btnChangeProfile = new Button();
            lblWelcome = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(44, 62, 80);
            pnlSidebar.Controls.Add(pnlSearchBar);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 5, 3, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(287, 1055);
            pnlSidebar.TabIndex = 2;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.FromArgb(44, 62, 80);
            pnlSearchBar.Controls.Add(txtMenuSearch);
            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Location = new Point(0, 69);
            pnlSearchBar.Margin = new Padding(3, 4, 3, 4);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Padding = new Padding(11, 13, 11, 13);
            pnlSearchBar.Size = new Size(287, 67);
            pnlSearchBar.TabIndex = 1;
            // 
            // txtMenuSearch
            // 
            txtMenuSearch.BackColor = Color.FromArgb(236, 240, 241);
            txtMenuSearch.BorderStyle = BorderStyle.None;
            txtMenuSearch.Dock = DockStyle.Fill;
            txtMenuSearch.Font = new Font("Segoe UI", 9F);
            txtMenuSearch.ForeColor = Color.FromArgb(44, 62, 80);
            txtMenuSearch.Location = new Point(11, 13);
            txtMenuSearch.Margin = new Padding(3, 4, 3, 4);
            txtMenuSearch.Name = "txtMenuSearch";
            txtMenuSearch.PlaceholderText = "Pesquisar menu...";
            txtMenuSearch.Size = new Size(265, 20);
            txtMenuSearch.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(287, 69);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "THOS";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(52, 152, 219);
            pnlHeader.Controls.Add(btnChangeProfile);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(287, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1313, 80);
            pnlHeader.TabIndex = 3;
            // 
            // btnChangeProfile
            // 
            btnChangeProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeProfile.BackColor = Color.FromArgb(44, 62, 80);
            btnChangeProfile.FlatAppearance.BorderSize = 0;
            btnChangeProfile.FlatStyle = FlatStyle.Flat;
            btnChangeProfile.Font = new Font("Segoe UI", 9F);
            btnChangeProfile.ForeColor = Color.White;
            btnChangeProfile.Location = new Point(1206, 20);
            btnChangeProfile.Margin = new Padding(3, 4, 3, 4);
            btnChangeProfile.Name = "btnChangeProfile";
            btnChangeProfile.Size = new Size(96, 40);
            btnChangeProfile.TabIndex = 1;
            btnChangeProfile.Text = "Trocar Perfil";
            btnChangeProfile.UseVisualStyleBackColor = false;
            btnChangeProfile.Click += BtnChangeProfile_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(17, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(116, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bem-vindo!";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(287, 80);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1313, 975);
            pnlContent.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1055);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THOS - Sistema de Gestão";
            Load += MainForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }
    }
}
