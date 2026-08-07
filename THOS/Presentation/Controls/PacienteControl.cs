using System;
using System.Windows.Forms;
using THOS.Client.Presentation.Controls;
using THOS.Client.Domain.Entities;
using THOS.Controls;

namespace THOS.Client.Presentation.Controls
{
    public partial class PacienteControl : UserControl
    {
        private PatientRegistrationControl _registrationControl = null!;
        private PatientSearchControl _searchControl = null!;

        public PacienteControl()
        {
            InitializeComponent();
            InitializeControls();
            CustomizeTabControl();
        }

        private void InitializeControls()
        {
            _searchControl = new PatientSearchControl { Dock = DockStyle.Fill };
            _searchControl.OnPatientSelectedForEdit += SearchControl_OnPatientSelectedForEdit;
            tbpSearch.Controls.Clear();
            tbpSearch.Controls.Add(_searchControl);

            _registrationControl = new PatientRegistrationControl { Dock = DockStyle.Fill };
            _registrationControl.OnCancelled += (s, e) => SwitchToSearchTab();
            _registrationControl.OnSaved += (s, e) => SwitchToSearchTab();
            _registrationControl.LoadPatient();
            tbpRegistration.Controls.Clear();
            tbpRegistration.Controls.Add(_registrationControl);

            _searchControl.LoadPatients();
        }

        private void CustomizeTabControl()
        {
            tbcPatients.ItemSize = new Size(0, 1);
            tbcPatients.SizeMode = TabSizeMode.Fixed;
            tbcPatients.Appearance = TabAppearance.Buttons;
        }

        private void SearchControl_OnPatientSelectedForEdit(object? sender, (LocalPatient Patient, LocalAnamnesis? Anamnesis) e)
        {
            _registrationControl.LoadPatient(e.Patient, e.Anamnesis);
            tbcPatients.SelectedTab = tbpRegistration;
        }

        private void SwitchToSearchTab() => tbcPatients.SelectedTab = tbpSearch;
    }
}
