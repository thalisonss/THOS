using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using THOS.Client.Infrastructure.Data;
using THOS.Client.Presentation.Controls;
using THOS.Client.Domain.Entities;
using THOS.Controls;

namespace THOS.Client.Presentation.Forms
{
    public partial class MainForm : Form
    {
        private Guid _userId;
        private int _menuYOffset = 140;
        private List<(Button Button, string Text)> _allMenuButtons = new();

        public MainForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserProfileAndMenus();
            txtMenuSearch.TextChanged += TxtMenuSearch_TextChanged;
        }

        private void TxtMenuSearch_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtMenuSearch.Text.ToLower();
            int yOffset = 140;

            foreach (var (btn, text) in _allMenuButtons)
            {
                bool matches = string.IsNullOrWhiteSpace(searchText) || text.ToLower().Contains(searchText);
                if (matches)
                {
                    btn.Location = new Point(0, yOffset);
                    btn.Visible = true;
                    yOffset += 45;
                }
                else
                {
                    btn.Visible = false;
                }
            }
        }

        private void LoadUserProfileAndMenus()
        {
            try
            {
                using var context = new ThosContext();
                var user = context.Users.Find(_userId);

                if (user != null)
                {
                    var profile = user.ProfileLastAccessId.HasValue
                        ? context.Profiles.Find(user.ProfileLastAccessId.Value)
                        : context.UserProfiles
                            .Where(up => up.UserId == _userId && up.IsActive && up.Profile != null && up.Profile.IsActive)
                            .Select(up => up.Profile)
                            .FirstOrDefault();

                    if (profile != null && (!user.ProfileLastAccessId.HasValue || user.ProfileLastAccessId.Value != profile.Id))
                    {
                        user.ProfileLastAccessId = profile.Id;
                        context.SaveChanges();
                    }

                    var profileName = profile != null ? profile.Name : "Sem Perfil";

                    lblWelcome.Text = $"Bem-vindo, {user.FullName} | Perfil Ativo: {profileName}";

                    BuildMenuBasedOnProfile(profileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar ambiente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildMenuBasedOnProfile(string profileName)
        {
            for (int i = pnlSidebar.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlSidebar.Controls[i] is Button)
                {
                    pnlSidebar.Controls.RemoveAt(i);
                }
            }

            pnlContent.Controls.Clear();
            _menuYOffset = 140;
            _allMenuButtons.Clear();
            string pName = profileName.ToUpper();

            if (pName.Contains("ADMIN") || pName.Contains("RECEPCIONISTA") || pName.Contains("DOUTOR"))
            {
                AddMenuButton("Paciente", () => LoadUserControl(new PacienteControl()));
            }

            if (pName.Contains("ADMIN"))
            {
                AddMenuButton("Usuários", () => LoadUserControl(new UsuarioControl()));
            }

            ShowDashboard();
        }

        private void AddMenuButton(string text, Action onClickAction)
        {
            Button btn = new Button
            {
                Text = text,
                Width = pnlSidebar.Width,
                Height = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(44, 62, 80),
                Location = new Point(0, _menuYOffset),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            btn.Click += (s, e) => onClickAction();
            pnlSidebar.Controls.Add(btn);
            _allMenuButtons.Add((btn, text));
            _menuYOffset += 45;
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void ShowDashboard()
        {
            pnlContent.Controls.Clear();
            Label lblDashboard = new Label
            {
                Text = "Selecione uma opção no menu lateral.",
                Font = new Font("Segoe UI", 14F, FontStyle.Regular),
                ForeColor = Color.FromArgb(149, 165, 166),
                AutoSize = true,
                Location = new Point(30, 30)
            };
            pnlContent.Controls.Add(lblDashboard);
        }

        private void BtnChangeProfile_Click(object sender, EventArgs e)
        {
            using (var profileForm = new SelectProfileForm(_userId))
            {
                if (profileForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUserProfileAndMenus();
                }
            }
        }
    }
}
