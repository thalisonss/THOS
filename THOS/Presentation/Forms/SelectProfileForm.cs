using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using THOS.Client.Domain.Entities;
using THOS.Client.Infrastructure.Data;

namespace THOS.Client.Presentation.Forms
{
    public partial class SelectProfileForm : Form
    {
        private readonly Guid _userId;

        public SelectProfileForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void SelectProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                using var context = new ThosContext();
                
                var userProfiles = context.UserProfiles
                    .Where(up => up.UserId == _userId && up.IsActive && up.Profile != null && up.Profile.IsActive)
                    .Select(up => up.Profile!)
                    .Distinct()
                    .ToList();

                if (!userProfiles.Any())
                {
                    MessageBox.Show("Você não possui perfis de acesso vinculados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnConfirm.Enabled = false;
                    return;
                }

                lstProfiles.DataSource = userProfiles;
                lstProfiles.DisplayMember = "Name";
                lstProfiles.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar perfis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstProfiles.SelectedValue == null)
            {
                MessageBox.Show("Selecione um perfil para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProfileId = (Guid)lstProfiles.SelectedValue;

            try
            {
                using var context = new ThosContext();
                var user = context.Users.Find(_userId);

                if (user != null)
                {
                    user.ProfileLastAccessId = selectedProfileId;
                    user.UpdatedAt = DateTime.UtcNow;
                    user.IsSynced = false;
                    context.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar último acesso: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}