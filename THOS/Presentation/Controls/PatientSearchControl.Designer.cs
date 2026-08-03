namespace THOS.Controls
{
    partial class PatientSearchControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSearchBar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblResultCount = new Label();
            dgvPatients = new DataGridView();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.Controls.Add(lblSearch);
            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(btnSearch);
            pnlSearchBar.Controls.Add(lblResultCount);
            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Location = new Point(0, 0);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1110, 92);
            pnlSearchBar.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(18, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Buscar paciente";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(18, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nome, CPF, telefone ou convênio";
            txtSearch.Size = new Size(790, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(824, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblResultCount
            // 
            lblResultCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResultCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultCount.Location = new Point(948, 43);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(146, 20);
            lblResultCount.TabIndex = 3;
            lblResultCount.Text = "0 paciente(s)";
            lblResultCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = SystemColors.Window;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.Location = new Point(0, 92);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1110, 906);
            dgvPatients.TabIndex = 1;
            // 
            // PatientSearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPatients);
            Controls.Add(pnlSearchBar);
            Name = "PatientSearchControl";
            Size = new Size(1110, 998);
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearchBar;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblResultCount;
        private DataGridView dgvPatients;
    }
}
