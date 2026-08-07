using System;
using System.Linq;
using System.Windows.Forms;
using THOS.Client.Infrastructure.Data;
using THOS.Client.Domain.Entities;

namespace THOS.Client.Presentation.Forms
{
    public partial class LoginForm : Form
    {
        public LocalUser? AuthenticatedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Informe o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var context = new ThosContext();
                
                // Em produção, isso usaria BCRYPT ou similar para comparar Hash
                var user = context.Users.FirstOrDefault(u => u.Login == txtLogin.Text && u.PasswordHash == txtPassword.Text);

                if (user != null && user.IsActive)
                {
                    AuthenticatedUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}