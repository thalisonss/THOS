using System;
using System.Windows.Forms;
using THOS.Client.Domain.Entities;
using THOS.Controls;

namespace THOS.Forms
{
    public partial class PatientManagementForm : Form
    {
        private PatientRegistrationControl _registrationControl = null!;
        private PatientSearchControl _searchControl = null!;

        public PatientManagementForm()
        {
            InitializeComponent();

            InitializeControls();
        }

        private void InitializeControls()
        {
            // 1. Inicializa o controle de BUSCA na tbpSearch
            _searchControl = new PatientSearchControl
            {
                Dock = DockStyle.Fill
            };

            // Evento: quando clicar duas vezes em um paciente da busca, abre para edição
            _searchControl.OnPatientSelectedForEdit += SearchControl_OnPatientSelectedForEdit;

            tbpSearch.Controls.Clear();
            tbpSearch.Controls.Add(_searchControl);

            // 2. Inicializa o controle de CADASTRO na tbpRegistration
            _registrationControl = new PatientRegistrationControl
            {
                Dock = DockStyle.Fill
            };

            // Evento: quando clicar em Cancelar, volta para a tela de pesquisa
            _registrationControl.OnCancelled += (s, e) => SwitchToSearchTab();
            _registrationControl.OnSaved += (s, e) => SwitchToSearchTab();

            _registrationControl.LoadPatient();

            tbpRegistration.Controls.Clear();
            tbpRegistration.Controls.Add(_registrationControl);

            // Carrega os pacientes já cadastrados na inicialização
            _searchControl.LoadPatients();
        }

        /// <summary>
        /// Chamado ao clicar duas vezes na linha do DataGridView do PatientSearchControl
        /// </summary>
        private void SearchControl_OnPatientSelectedForEdit(object? sender, (LocalPatient Patient, LocalAnamnesis? Anamnesis) data)
        {
            // Carrega o Paciente e a Anamnese no controle de cadastro
            _registrationControl.LoadPatient(data.Patient, data.Anamnesis);

            // Alterna para a aba de Cadastro/Edição
            tbcPatients.SelectedTab = tbpRegistration;
        }

        /// <summary>
        /// Alterna para a aba de busca e atualiza a grid
        /// </summary>
        private void SwitchToSearchTab()
        {
            _searchControl.LoadPatients();
            tbcPatients.SelectedTab = tbpSearch;
        }
    }
}
