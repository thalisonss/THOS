namespace THOS.Client.Presentation.Forms
{
    partial class SelectProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLogoPanel;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.Button btnConfirm;

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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLogoPanel = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();

            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            
            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlLeft.Controls.Add(this.lblLogoPanel);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Size = new System.Drawing.Size(200, 400);
            
            // lblLogoPanel
            this.lblLogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoPanel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogoPanel.ForeColor = System.Drawing.Color.White;
            this.lblLogoPanel.Name = "lblLogoPanel";
            this.lblLogoPanel.Text = "THOS";
            this.lblLogoPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // pnlRight
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnConfirm);
            this.pnlRight.Controls.Add(this.lstProfiles);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Size = new System.Drawing.Size(320, 400);
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location = new System.Drawing.Point(25, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Selecionar Perfil";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(25, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Escolha com qual perfil deseja acessar o sistema:";
            
            // lstProfiles
            this.lstProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProfiles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstProfiles.ItemHeight = 25;
            this.lstProfiles.Location = new System.Drawing.Point(25, 90);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(270, 230);
            
            // btnConfirm
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(25, 340);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(270, 40);
            this.btnConfirm.Text = "ACESSAR";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            
            // SelectProfileForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Perfil";
            this.Load += new System.EventHandler(this.SelectProfileForm_Load);
            
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}