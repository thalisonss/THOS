using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using THOS.Client.Domain.Entities;
using THOS.Client.Infrastructure.Data.Repositories;

namespace THOS.Controls
{
    public partial class PatientSearchControl : UserControl
    {
        private readonly PatientRepository _patientRepository;

        // Evento disparado quando o usuário clica duas vezes em um paciente para editar
        public event EventHandler<(LocalPatient Patient, LocalAnamnesis? Anamnesis)>? OnPatientSelectedForEdit;

        public PatientSearchControl()
        {
            InitializeComponent();

            _patientRepository = new PatientRepository();

            ConfigureDataGridView();
            SetupEvents();
        }

        /// <summary>
        /// Aplica o estilo visual do THOS ao DataGridView (Segoe UI, linhas alternadas)
        /// </summary>
        private void ConfigureDataGridView()
        {
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.ReadOnly = true;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.MultiSelect = false;

            // Fontes e Cores
            dgvPatients.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 50, 70);
            dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);

            // Mapeamento das Colunas vinculadas às propriedades de LocalPatient
            dgvPatients.Columns.Clear();

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Nome Completo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TaxId",
                HeaderText = "CPF",
                Width = 130
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MobilePhone",
                HeaderText = "Telefone / WhatsApp",
                Width = 150
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InsuranceProvider",
                HeaderText = "Convênio",
                Width = 130
            });
        }

        private void SetupEvents()
        {
            // Pesquisa conforme digita
            txtSearch.TextChanged += (s, e) => ExecuteSearch();
            btnSearch.Click += (s, e) => ExecuteSearch();

            // Duplo clique na linha para abrir edição
            dgvPatients.CellDoubleClick += DgvPatients_CellDoubleClick;
        }

        /// <summary>
        /// Carrega ou atualiza a lista de pacientes no DataGridView
        /// </summary>
        public void LoadPatients()
        {
            ExecuteSearch();
        }

        private void ExecuteSearch()
        {
            try
            {
                string query = txtSearch.Text.Trim();
                List<LocalPatient> results = _patientRepository.Search(query);

                dgvPatients.DataSource = null;
                dgvPatients.DataSource = results;

                lblResultCount.Text = $"{results.Count} paciente(s) encontrado(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao buscar pacientes no banco de dados local:\n{ex.Message}",
                    "Erro na Busca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DgvPatients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPatients.Rows[e.RowIndex].DataBoundItem is LocalPatient selectedPatient)
            {
                // Busca a Anamnese vinculada ao paciente no SQLite
                LocalAnamnesis? anamnesis = _patientRepository.GetAnamnesisByPatientId(selectedPatient.Id);

                // Dispara evento para o PatientManagementForm alternar para a aba de cadastro e carregar os dados
                OnPatientSelectedForEdit?.Invoke(this, (selectedPatient, anamnesis));
            }
        }
    }
}