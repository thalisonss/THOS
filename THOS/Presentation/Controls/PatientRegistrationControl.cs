using System;
using System.Drawing;
using System.Windows.Forms;
using THOS.Client.Domain.Entities;
using THOS.Client.Infrastructure.Data.Repositories;
using THOS.Client.Presentation.Validation;
using THOS.Client.Shared.Validation;
using THOS.Client.Shared.Validation.WinForms;

namespace THOS.Controls
{
    public partial class PatientRegistrationControl : UserControl
    {
        // Eventos para notificar o formulário pai.
        public event EventHandler? OnCancelled;
        public event EventHandler? OnSaved;

        private static readonly string[] AllowedGenders =
        [
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não informar",
            "PreferNotToSay"
        ];

        private static readonly string[] AllowedStates =
        [
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
            "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        ];

        private readonly PatientRepository _patientRepository;
        private readonly FormFieldValidationManager _validationManager;

        private LocalPatient _currentPatient = new();
        private LocalAnamnesis _currentAnamnesis = new();
        private string _defaultStatusMessage = "Novo cadastro";

        public PatientRegistrationControl()
        {
            InitializeComponent();

            _patientRepository = new PatientRepository();
            _validationManager = new FormFieldValidationManager(this);
            components?.Add(_validationManager);
            _validationManager.ValidationStateChanged += (_, _) => UpdateStatusFromValidation();

            ConfigureValidationRules();
            SetupEvents();
        }

        /// <summary>
        /// Carrega um paciente na tela ou limpa os campos para um novo cadastro.
        /// </summary>
        public void LoadPatient(LocalPatient? patient = null, LocalAnamnesis? anamnesis = null)
        {
            bool isNewRecord = patient is null && anamnesis is null;

            _currentPatient = patient ?? new LocalPatient();
            _currentAnamnesis = anamnesis ?? new LocalAnamnesis();
            _defaultStatusMessage = isNewRecord
                ? "Novo cadastro"
                : $"Editando paciente: {_currentPatient.FullName}";

            _validationManager.BeginBulkUpdate();
            try
            {
                txtFullName.Text = _currentPatient.FullName;
                SetMaskedValue(txtTaxId, _currentPatient.TaxId);
                txtIdentityCard.Text = _currentPatient.IdentityCard;

                if (_currentPatient.BirthDate.HasValue)
                {
                    dtpBirthDate.Checked = true;
                    dtpBirthDate.Value = _currentPatient.BirthDate.Value;
                }
                else
                {
                    dtpBirthDate.Checked = false;
                    dtpBirthDate.Value = DateTime.Today;
                }

                cmbGender.Text = NormalizeGenderForDisplay(_currentPatient.Gender);
                txtMobilePhone.Text = _currentPatient.MobilePhone;
                txtEmail.Text = _currentPatient.Email;
                txtEmergencyContactName.Text = _currentPatient.EmergencyContactName;
                SetMaskedValue(txtEmergencyPhone, _currentPatient.EmergencyPhone);

                cmbInsuranceProvider.Text = _currentPatient.InsuranceProvider;
                txtInsurancePolicyNumber.Text = _currentPatient.InsurancePolicyNumber;
                txtDrugAllergies.Text = _currentPatient.DrugAllergies;
                txtMedicalNotes.Text = _currentPatient.MedicalNotes;

                SetMaskedValue(txtPostalCode, _currentPatient.PostalCode);
                txtStreetAddress.Text = _currentPatient.StreetAddress;
                txtDistrict.Text = _currentPatient.District;
                txtCity.Text = _currentPatient.City;
                cmbState.Text = _currentPatient.State;

                chkHeartDisease.Checked = _currentAnamnesis.HasHeartDisease;
                chkDiabetes.Checked = _currentAnamnesis.HasDiabetes;
                chkHypertension.Checked = _currentAnamnesis.HasHypertension;
                chkPregnant.Checked = _currentAnamnesis.IsPregnant;
                chkBleeder.Checked = _currentAnamnesis.IsBleeder;
                txtMedications.Text = _currentAnamnesis.ContinuousMedications;
                txtSurgicalHistory.Text = _currentAnamnesis.SurgicalHistory;
                txtChiefComplaint.Text = _currentAnamnesis.ChiefComplaint;
                chkIsActive.Checked = _currentPatient.IsActive;
            }
            finally
            {
                _validationManager.EndBulkUpdate();
            }

            _validationManager.Clear();
            RestoreDefaultStatus();
        }

        private void ConfigureValidationRules()
        {
            // Regras que precisam ficar vermelhas tanto ao digitar quanto ao sair do campo.
            _validationManager.AddDefinition(new FieldValidationDefinition(
                "FullName",
                txtFullName,
                () => !string.IsNullOrWhiteSpace(txtFullName.Text),
                "O nome completo é obrigatório."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "TaxId",
                txtTaxId,
                () => !string.IsNullOrWhiteSpace(txtTaxId.Text) && ValidationRules.IsValidCpf(txtTaxId.Text),
                "CPF inválido ou não informado."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "BirthDate",
                dtpBirthDate,
                () => dtpBirthDate.Checked && dtpBirthDate.Value.Date <= DateTime.Today,
                "A data de nascimento é obrigatória e não pode ser futura."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "MobilePhone",
                txtMobilePhone,
                () => !string.IsNullOrWhiteSpace(txtMobilePhone.Text) && ValidationRules.IsValidPhone(txtMobilePhone.Text),
                "Telefone celular inválido ou não informado."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "Email",
                txtEmail,
                () => !string.IsNullOrWhiteSpace(txtEmail.Text) && ValidationRules.IsValidEmail(txtEmail.Text),
                "E-mail inválido ou não informado."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "PostalCode",
                txtPostalCode,
                () => !string.IsNullOrWhiteSpace(txtPostalCode.Text) && ValidationRules.IsValidPostalCode(txtPostalCode.Text),
                "CEP inválido ou não informado."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "StreetAddress",
                txtStreetAddress,
                () => !string.IsNullOrWhiteSpace(txtStreetAddress.Text),
                "O logradouro é obrigatório."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "City",
                txtCity,
                () => !string.IsNullOrWhiteSpace(txtCity.Text),
                "A cidade é obrigatória."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "State",
                cmbState,
                () => !string.IsNullOrWhiteSpace(cmbState.Text) && ValidationRules.IsAllowedValue(cmbState.Text, AllowedStates, false),
                "A UF é obrigatória e deve ser válida."));

            // Campos opcionais com validação de formato caso sejam preenchidos.
            _validationManager.AddDefinition(new FieldValidationDefinition(
                "Gender",
                cmbGender,
                () => ValidationRules.IsAllowedValue(cmbGender.Text, AllowedGenders, true),
                "Selecione um gênero válido."));

            _validationManager.AddDefinition(new FieldValidationDefinition(
                "EmergencyPhone",
                txtEmergencyPhone,
                () => ValidationRules.IsValidPhone(txtEmergencyPhone.Text),
                "Telefone de emergência inválido."));
        }

        private void SetupEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, _) => OnCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            ValidationResult validationResult = PatientRegistrationValidator.Validate(BuildFormData());
            _validationManager.ApplyResult(validationResult);

            if (!validationResult.IsValid)
            {
                FocusFirstInvalidControl(validationResult);
                return;
            }

            try
            {
                MapPatientFromForm();
                MapAnamnesisFromForm();

                _patientRepository.Save(_currentPatient, _currentAnamnesis);

                MessageBox.Show(
                    "Paciente e anamnese salvos com sucesso!",
                    "THOS - Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                OnSaved?.Invoke(this, EventArgs.Empty);
                LoadPatient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao salvar os dados no banco SQLite:\n{ex.Message}",
                    "Erro ao Salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UpdateStatusFromValidation()
        {
            if (_validationManager.Issues.Count == 0)
            {
                RestoreDefaultStatus();
                return;
            }

            lblFormStatus.ForeColor = Color.Firebrick;
            lblFormStatus.Text = _validationManager.Issues[0].Message;
        }

        private void RestoreDefaultStatus()
        {
            lblFormStatus.ForeColor = SystemColors.ControlText;
            lblFormStatus.Text = _defaultStatusMessage;
        }

        private void FocusFirstInvalidControl(ValidationResult validationResult)
        {
            if (validationResult.Issues.Count == 0)
            {
                return;
            }

            ValidationIssue firstIssue = validationResult.Issues[0];
            if (!_validationManager.TryGetControl(firstIssue.FieldName, out Control? control) || control is null)
            {
                return;
            }

            control.Focus();
        }

        private PatientRegistrationData BuildFormData()
        {
            return new PatientRegistrationData(
                txtFullName.Text.Trim(),
                txtTaxId.Text.Trim(),
                txtIdentityCard.Text.Trim(),
                dtpBirthDate.Checked ? dtpBirthDate.Value : (DateTime?)null,
                cmbGender.Text.Trim(),
                txtMobilePhone.Text.Trim(),
                txtEmail.Text.Trim(),
                txtEmergencyContactName.Text.Trim(),
                txtEmergencyPhone.Text.Trim(),
                cmbInsuranceProvider.Text.Trim(),
                txtInsurancePolicyNumber.Text.Trim(),
                txtDrugAllergies.Text.Trim(),
                txtMedicalNotes.Text.Trim(),
                txtPostalCode.Text.Trim(),
                txtStreetAddress.Text.Trim(),
                txtDistrict.Text.Trim(),
                txtCity.Text.Trim(),
                cmbState.Text.Trim(),
                chkHeartDisease.Checked,
                chkDiabetes.Checked,
                chkHypertension.Checked,
                chkPregnant.Checked,
                chkBleeder.Checked,
                txtMedications.Text.Trim(),
                txtSurgicalHistory.Text.Trim(),
                txtChiefComplaint.Text.Trim(),
                chkIsActive.Checked);
        }

        private void MapPatientFromForm()
        {
            // O mapeamento fica separado da validação para facilitar manutenção.
            _currentPatient.FullName = txtFullName.Text.Trim();
            _currentPatient.TaxId = txtTaxId.Text.Trim();
            _currentPatient.IdentityCard = txtIdentityCard.Text.Trim();
            _currentPatient.BirthDate = dtpBirthDate.Checked ? dtpBirthDate.Value : (DateTime?)null;
            _currentPatient.Gender = NormalizeGenderForStorage(cmbGender.Text.Trim());
            _currentPatient.MobilePhone = txtMobilePhone.Text.Trim();
            _currentPatient.Email = txtEmail.Text.Trim();
            _currentPatient.EmergencyContactName = txtEmergencyContactName.Text.Trim();
            _currentPatient.EmergencyPhone = txtEmergencyPhone.Text.Trim();

            _currentPatient.InsuranceProvider = cmbInsuranceProvider.Text.Trim();
            _currentPatient.InsurancePolicyNumber = txtInsurancePolicyNumber.Text.Trim();
            _currentPatient.DrugAllergies = txtDrugAllergies.Text.Trim();
            _currentPatient.MedicalNotes = txtMedicalNotes.Text.Trim();
            _currentPatient.IsActive = chkIsActive.Checked;

            _currentPatient.PostalCode = txtPostalCode.Text.Trim();
            _currentPatient.StreetAddress = txtStreetAddress.Text.Trim();
            _currentPatient.District = txtDistrict.Text.Trim();
            _currentPatient.City = txtCity.Text.Trim();
            _currentPatient.State = cmbState.Text.Trim();
        }

        private void MapAnamnesisFromForm()
        {
            _currentAnamnesis.HasHeartDisease = chkHeartDisease.Checked;
            _currentAnamnesis.HasDiabetes = chkDiabetes.Checked;
            _currentAnamnesis.HasHypertension = chkHypertension.Checked;
            _currentAnamnesis.IsPregnant = chkPregnant.Checked;
            _currentAnamnesis.IsBleeder = chkBleeder.Checked;
            _currentAnamnesis.ContinuousMedications = txtMedications.Text.Trim();
            _currentAnamnesis.SurgicalHistory = txtSurgicalHistory.Text.Trim();
            _currentAnamnesis.ChiefComplaint = txtChiefComplaint.Text.Trim();
            _currentAnamnesis.IsActive = chkIsActive.Checked;
        }

        private static void SetMaskedValue(MaskedTextBox box, string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                box.Clear();
                return;
            }

            box.Text = value;
        }

        private static string NormalizeGenderForDisplay(string? gender)
        {
            return gender?.Trim() switch
            {
                "PreferNotToSay" => "Prefiro não informar",
                "Prefiro não informar" => "Prefiro não informar",
                "Masculino" => "Masculino",
                "Feminino" => "Feminino",
                "Outro" => "Outro",
                _ => "Prefiro não informar"
            };
        }

        private static string NormalizeGenderForStorage(string? gender)
        {
            return gender?.Trim() switch
            {
                "Prefiro não informar" => "PreferNotToSay",
                "Masculino" => "Masculino",
                "Feminino" => "Feminino",
                "Outro" => "Outro",
                "PreferNotToSay" => "PreferNotToSay",
                _ => string.Empty
            };
        }
    }
}
