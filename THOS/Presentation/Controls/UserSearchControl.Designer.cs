namespace THOS.Client.Presentation.Controls
{
    partial class UserSearchControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;

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
            pnlSearchBar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvUsers = new DataGridView();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            pnlSearchBar.BackColor = Color.FromArgb(236, 240, 241);
            pnlSearchBar.Controls.Add(lblSearch);
            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Location = new Point(0, 0);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Padding = new Padding(15, 10, 15, 10);
            pnlSearchBar.Size = new Size(1110, 60);
            pnlSearchBar.TabIndex = 0;

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.Location = new Point(15, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Buscar:";

            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(70, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Digite nome ou login...";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 60);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(1110, 680);
            dgvUsers.TabIndex = 1;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsers);
            Controls.Add(pnlSearchBar);
            Name = "UserSearchControl";
            Size = new Size(1110, 740);
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }
    }
}
