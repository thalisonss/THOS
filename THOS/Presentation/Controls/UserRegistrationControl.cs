using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using THOS.Client.Domain.Entities;
using THOS.Client.Infrastructure.Data;

namespace THOS.Client.Presentation.Controls
{
    public partial class UserRegistrationControl : UserControl
    {
        private List<LocalProfile> _allProfiles;
        private LocalUser? _currentUser;

        public event EventHandler? OnCancelled;
        public event EventHandler? OnSaved;

        public UserRegistrationControl()
        {
            InitializeComponent();
            _allProfiles = new List<LocalProfile>();
        }

        private void UserRegistrationControl_Load(object sender, EventArgs e)
        {
            try
            {
                using var context = new ThosContext();
                _allProfiles = context.Profiles.Where(p => p.IsActive).ToList();
                PopulateGrid(_allProfiles);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar perfis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUser(LocalUser user, List<LocalProfile> assignedProfiles)
        {
            _currentUser = user;
            txtFullName.Text = user.FullName;
            txtLogin.Text = user.Login;
            txtPassword.Text = user.PasswordHash;

            foreach (DataGridViewRow row in dgvProfiles.Rows)
            {
                var profileId = (Guid)row.Cells["Id"].Value;
                row.Cells["Selected"].Value = assignedProfiles.Any(p => p.Id == profileId);
            }
        }

        private void txtSearchProfile_TextChanged(object sender, EventArgs e)
        {
            var filter = txtSearchProfile.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                PopulateGrid(_allProfiles);
            }
            else
            {
                var filtered = _allProfiles.Where(p => p.Name.ToLower().Contains(filter)).ToList();
                PopulateGrid(filtered);
            }
        }

        private void PopulateGrid(List<LocalProfile> profiles)
        {
            dgvProfiles.Rows.Clear();
            foreach (var profile in profiles)
            {
                dgvProfiles.Rows.Add(false, profile.Id, profile.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                using var context = new ThosContext();

                if (_currentUser == null)
                {
                    _currentUser = new LocalUser
                    {
                        Id = Guid.NewGuid(),
                        FullName = txtFullName.Text,
                        Login = txtLogin.Text,
                        PasswordHash = txtPassword.Text,
                        IsActive = true
                    };
                    context.Users.Add(_currentUser);
                }
                else
                {
                    _currentUser.FullName = txtFullName.Text;
                    _currentUser.Login = txtLogin.Text;
                    _currentUser.PasswordHash = txtPassword.Text;
                }

                context.SaveChanges();

                var selectedProfileIds = dgvProfiles.Rows.Cast<DataGridViewRow>()
                    .Where(r => (bool)r.Cells["Selected"].Value)
                    .Select(r => (Guid)r.Cells["Id"].Value)
                    .ToList();

                var currentLinks = context.UserProfiles.Where(up => up.UserId == _currentUser.Id).ToList();
                foreach (var link in currentLinks)
                {
                    context.UserProfiles.Remove(link);
                }

                foreach (var profileId in selectedProfileIds)
                {
                    context.UserProfiles.Add(new LocalUserProfile
                    {
                        Id = Guid.NewGuid(),
                        UserId = _currentUser.Id,
                        ProfileId = profileId,
                        IsActive = true
                    });
                }

                context.SaveChanges();
                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnSaved?.Invoke(this, EventArgs.Empty);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelled?.Invoke(this, EventArgs.Empty);
            ClearForm();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            _currentUser = null;
            foreach (DataGridViewRow row in dgvProfiles.Rows)
            {
                row.Cells["Selected"].Value = false;
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("O Nome Completo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("O Login é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("A Senha é obrigatória.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!dgvProfiles.Rows.Cast<DataGridViewRow>().Any(r => (bool)r.Cells["Selected"].Value))
            {
                MessageBox.Show("Selecione ao menos um perfil de acesso para o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
