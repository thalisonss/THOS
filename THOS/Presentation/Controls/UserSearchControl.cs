using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using THOS.Client.Domain.Entities;
using THOS.Client.Infrastructure.Data;

namespace THOS.Client.Presentation.Controls
{
    public partial class UserSearchControl : UserControl
    {
        public event EventHandler<(LocalUser User, List<LocalProfile> AssignedProfiles)>? OnUserSelectedForEdit;

        public UserSearchControl()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;

            dgvUsers.Font = new Font("Segoe UI", 9.5F);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 50, 70);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 247);

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", DataPropertyName = "FullName", HeaderText = "Nome Completo", Width = 250 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "Login", DataPropertyName = "Login", HeaderText = "Login", Width = 150 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "IsActive", DataPropertyName = "IsActive", HeaderText = "Ativo", Width = 80 });

            dgvUsers.DoubleClick += DgvUsers_DoubleClick;
        }

        private void DgvUsers_DoubleClick(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            var userId = (Guid)dgvUsers.SelectedRows[0].Cells["Id"].Value;
            using var context = new ThosContext();
            var user = context.Users.Find(userId);
            if (user == null) return;

            var profiles = context.UserProfiles
                .Where(up => up.UserId == userId)
                .Select(up => up.Profile!)
                .ToList();

            OnUserSelectedForEdit?.Invoke(this, (user, profiles));
        }

        public void LoadUsers()
        {
            try
            {
                using var context = new ThosContext();
                var users = context.Users.Where(u => u.IsActive).ToList();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string filter = txtSearch.Text.ToLower();
                using var context = new ThosContext();
                var users = string.IsNullOrWhiteSpace(filter)
                    ? context.Users.Where(u => u.IsActive).ToList()
                    : context.Users.Where(u => u.IsActive && (u.FullName.ToLower().Contains(filter) || u.Login.ToLower().Contains(filter))).ToList();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na pesquisa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
