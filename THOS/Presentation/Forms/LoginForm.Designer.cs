namespace THOS.Client.Presentation.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblExit;

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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlLeft.Controls.Add(this.lblSubtitle);
            this.pnlLeft.Controls.Add(this.lblLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 350);
            
            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 80);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 60);
            this.lblLogo.Text = "THOS";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // lblSubtitle
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 140);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(250, 40);
            this.lblSubtitle.Text = "Sistema Odontológico";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblExit);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtLogin);
            this.pnlRight.Controls.Add(this.lblLogin);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(250, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 350);
            
            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLogin.ForeColor = System.Drawing.Color.Gray;
            this.lblLogin.Location = new System.Drawing.Point(40, 80);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Text = "Usuário";
            
            // txtLogin
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLogin.Location = new System.Drawing.Point(40, 105);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(270, 29);
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(40, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Senha";
            
            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(40, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 29);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 40);
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            
            // lblExit
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.lblExit.ForeColor = System.Drawing.Color.Gray;
            this.lblExit.Location = new System.Drawing.Point(160, 300);
            this.lblExit.Name = "lblExit";
            this.lblExit.Text = "Sair";
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            
            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}