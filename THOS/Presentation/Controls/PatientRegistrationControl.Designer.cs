namespace THOS.Controls
{
    partial class PatientRegistrationControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpPersonalInfo = new GroupBox();
            lblIdentityCard = new Label();
            txtIdentityCard = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblTaxId = new Label();
            txtTaxId = new MaskedTextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            grpContactInfo = new GroupBox();
            lblEmergencyPhone = new Label();
            txtEmergencyPhone = new MaskedTextBox();
            lblEmergencyContactName = new Label();
            txtEmergencyContactName = new TextBox();
            lblMobilePhone = new Label();
            txtMobilePhone = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            grpMedicalInfo = new GroupBox();
            lblSurgicalHistory = new Label();
            txtSurgicalHistory = new TextBox();
            lblMedicalNotes = new Label();
            txtMedicalNotes = new TextBox();
            lblInsuranceProvider = new Label();
            cmbInsuranceProvider = new ComboBox();
            lblInsurancePolicyNumber = new Label();
            txtInsurancePolicyNumber = new TextBox();
            lblDrugAllergies = new Label();
            txtDrugAllergies = new TextBox();
            grpAddressInfo = new GroupBox();
            lblState = new Label();
            cmbState = new ComboBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblDistrict = new Label();
            txtDistrict = new TextBox();
            lblPostalCode = new Label();
            txtPostalCode = new MaskedTextBox();
            lblStreetAddress = new Label();
            txtStreetAddress = new TextBox();
            grpAnamnesis = new GroupBox();
            lblChiefComplaint = new Label();
            txtChiefComplaint = new TextBox();
            lblMedications = new Label();
            txtMedications = new TextBox();
            chkBleeder = new CheckBox();
            chkPregnant = new CheckBox();
            chkHypertension = new CheckBox();
            chkDiabetes = new CheckBox();
            chkHeartDisease = new CheckBox();
            pnlActions = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            chkIsActive = new CheckBox();
            lblFormStatus = new Label();
            grpPersonalInfo.SuspendLayout();
            grpContactInfo.SuspendLayout();
            grpMedicalInfo.SuspendLayout();
            grpAddressInfo.SuspendLayout();
            grpAnamnesis.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(lblIdentityCard);
            grpPersonalInfo.Controls.Add(txtIdentityCard);
            grpPersonalInfo.Controls.Add(lblGender);
            grpPersonalInfo.Controls.Add(cmbGender);
            grpPersonalInfo.Controls.Add(lblBirthDate);
            grpPersonalInfo.Controls.Add(dtpBirthDate);
            grpPersonalInfo.Controls.Add(lblTaxId);
            grpPersonalInfo.Controls.Add(txtTaxId);
            grpPersonalInfo.Controls.Add(lblFullName);
            grpPersonalInfo.Controls.Add(txtFullName);
            grpPersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPersonalInfo.Location = new Point(12, 12);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(1086, 178);
            grpPersonalInfo.TabIndex = 0;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Dados pessoais";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(20, 32);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(124, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Nome completo";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(20, 55);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(460, 27);
            txtFullName.TabIndex = 0;
            // 
            // lblTaxId
            // 
            lblTaxId.AutoSize = true;
            lblTaxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxId.Location = new Point(498, 32);
            lblTaxId.Name = "lblTaxId";
            lblTaxId.Size = new Size(40, 20);
            lblTaxId.TabIndex = 3;
            lblTaxId.Text = "CPF";
            // 
            // txtTaxId
            // 
            txtTaxId.Location = new Point(498, 55);
            txtTaxId.Mask = "000.000.000-00";
            txtTaxId.Name = "txtTaxId";
            txtTaxId.Size = new Size(176, 27);
            txtTaxId.TabIndex = 2;
            txtTaxId.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthDate.Location = new Point(690, 32);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(151, 20);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Data de nascimento";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.ShowCheckBox = true;
            dtpBirthDate.Location = new Point(690, 55);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(140, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(855, 32);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 20);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gênero";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDown;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro", "Prefiro não informar" });
            cmbGender.Location = new Point(855, 55);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(205, 28);
            cmbGender.TabIndex = 6;
            // 
            // lblIdentityCard
            // 
            lblIdentityCard.AutoSize = true;
            lblIdentityCard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentityCard.Location = new Point(20, 101);
            lblIdentityCard.Name = "lblIdentityCard";
            lblIdentityCard.Size = new Size(39, 20);
            lblIdentityCard.TabIndex = 9;
            lblIdentityCard.Text = "RG";
            // 
            // txtIdentityCard
            // 
            txtIdentityCard.Location = new Point(20, 124);
            txtIdentityCard.Name = "txtIdentityCard";
            txtIdentityCard.Size = new Size(200, 27);
            txtIdentityCard.TabIndex = 8;
            // 
            // grpContactInfo
            // 
            grpContactInfo.Controls.Add(lblEmergencyPhone);
            grpContactInfo.Controls.Add(txtEmergencyPhone);
            grpContactInfo.Controls.Add(lblEmergencyContactName);
            grpContactInfo.Controls.Add(txtEmergencyContactName);
            grpContactInfo.Controls.Add(lblMobilePhone);
            grpContactInfo.Controls.Add(txtMobilePhone);
            grpContactInfo.Controls.Add(lblEmail);
            grpContactInfo.Controls.Add(txtEmail);
            grpContactInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpContactInfo.Location = new Point(12, 196);
            grpContactInfo.Name = "grpContactInfo";
            grpContactInfo.Size = new Size(1086, 163);
            grpContactInfo.TabIndex = 1;
            grpContactInfo.TabStop = false;
            grpContactInfo.Text = "Contato";
            // 
            // lblMobilePhone
            // 
            lblMobilePhone.AutoSize = true;
            lblMobilePhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMobilePhone.Location = new Point(20, 32);
            lblMobilePhone.Name = "lblMobilePhone";
            lblMobilePhone.Size = new Size(121, 20);
            lblMobilePhone.TabIndex = 3;
            lblMobilePhone.Text = "Telefone celular";
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(20, 55);
            txtMobilePhone.Mask = "(00) 00000-0000";
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(190, 27);
            txtMobilePhone.TabIndex = 2;
            txtMobilePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(230, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(230, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblEmergencyContactName
            // 
            lblEmergencyContactName.AutoSize = true;
            lblEmergencyContactName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyContactName.Location = new Point(612, 32);
            lblEmergencyContactName.Name = "lblEmergencyContactName";
            lblEmergencyContactName.Size = new Size(209, 20);
            lblEmergencyContactName.TabIndex = 5;
            lblEmergencyContactName.Text = "Contato de emergência";
            // 
            // txtEmergencyContactName
            // 
            txtEmergencyContactName.Location = new Point(612, 55);
            txtEmergencyContactName.Name = "txtEmergencyContactName";
            txtEmergencyContactName.Size = new Size(448, 27);
            txtEmergencyContactName.TabIndex = 4;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.AutoSize = true;
            lblEmergencyPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyPhone.Location = new Point(20, 95);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(175, 20);
            lblEmergencyPhone.TabIndex = 7;
            lblEmergencyPhone.Text = "Telefone de emergência";
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Location = new Point(20, 118);
            txtEmergencyPhone.Mask = "(00) 00000-0000";
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(190, 27);
            txtEmergencyPhone.TabIndex = 6;
            txtEmergencyPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // grpMedicalInfo
            // 
            grpMedicalInfo.Controls.Add(lblSurgicalHistory);
            grpMedicalInfo.Controls.Add(txtSurgicalHistory);
            grpMedicalInfo.Controls.Add(lblMedicalNotes);
            grpMedicalInfo.Controls.Add(txtMedicalNotes);
            grpMedicalInfo.Controls.Add(lblInsuranceProvider);
            grpMedicalInfo.Controls.Add(cmbInsuranceProvider);
            grpMedicalInfo.Controls.Add(lblInsurancePolicyNumber);
            grpMedicalInfo.Controls.Add(txtInsurancePolicyNumber);
            grpMedicalInfo.Controls.Add(lblDrugAllergies);
            grpMedicalInfo.Controls.Add(txtDrugAllergies);
            grpMedicalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMedicalInfo.Location = new Point(12, 365);
            grpMedicalInfo.Name = "grpMedicalInfo";
            grpMedicalInfo.Size = new Size(1086, 212);
            grpMedicalInfo.TabIndex = 2;
            grpMedicalInfo.TabStop = false;
            grpMedicalInfo.Text = "Convênio e alertas médicos";
            // 
            // lblDrugAllergies
            // 
            lblDrugAllergies.AutoSize = true;
            lblDrugAllergies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrugAllergies.Location = new Point(20, 32);
            lblDrugAllergies.Name = "lblDrugAllergies";
            lblDrugAllergies.Size = new Size(178, 20);
            lblDrugAllergies.TabIndex = 1;
            lblDrugAllergies.Text = "Alergia a medicamentos";
            // 
            // txtDrugAllergies
            // 
            txtDrugAllergies.Location = new Point(20, 55);
            txtDrugAllergies.Multiline = true;
            txtDrugAllergies.Name = "txtDrugAllergies";
            txtDrugAllergies.ScrollBars = ScrollBars.Vertical;
            txtDrugAllergies.Size = new Size(325, 130);
            txtDrugAllergies.TabIndex = 0;
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicalNotes.Location = new Point(361, 32);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(141, 20);
            lblMedicalNotes.TabIndex = 9;
            lblMedicalNotes.Text = "Condições médicas";
            // 
            // txtMedicalNotes
            // 
            txtMedicalNotes.Location = new Point(361, 55);
            txtMedicalNotes.Multiline = true;
            txtMedicalNotes.Name = "txtMedicalNotes";
            txtMedicalNotes.ScrollBars = ScrollBars.Vertical;
            txtMedicalNotes.Size = new Size(325, 130);
            txtMedicalNotes.TabIndex = 8;
            // 
            // lblInsuranceProvider
            // 
            lblInsuranceProvider.AutoSize = true;
            lblInsuranceProvider.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsuranceProvider.Location = new Point(705, 32);
            lblInsuranceProvider.Name = "lblInsuranceProvider";
            lblInsuranceProvider.Size = new Size(189, 20);
            lblInsuranceProvider.TabIndex = 7;
            lblInsuranceProvider.Text = "Convênio / plano de saúde";
            // 
            // cmbInsuranceProvider
            // 
            cmbInsuranceProvider.FormattingEnabled = true;
            cmbInsuranceProvider.Location = new Point(705, 55);
            cmbInsuranceProvider.Name = "cmbInsuranceProvider";
            cmbInsuranceProvider.Size = new Size(183, 28);
            cmbInsuranceProvider.TabIndex = 6;
            // 
            // lblInsurancePolicyNumber
            // 
            lblInsurancePolicyNumber.AutoSize = true;
            lblInsurancePolicyNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsurancePolicyNumber.Location = new Point(705, 95);
            lblInsurancePolicyNumber.Name = "lblInsurancePolicyNumber";
            lblInsurancePolicyNumber.Size = new Size(147, 20);
            lblInsurancePolicyNumber.TabIndex = 3;
            lblInsurancePolicyNumber.Text = "Número da carteira";
            // 
            // txtInsurancePolicyNumber
            // 
            txtInsurancePolicyNumber.Location = new Point(705, 118);
            txtInsurancePolicyNumber.Name = "txtInsurancePolicyNumber";
            txtInsurancePolicyNumber.Size = new Size(183, 27);
            txtInsurancePolicyNumber.TabIndex = 2;
            // 
            // lblSurgicalHistory
            // 
            lblSurgicalHistory.AutoSize = true;
            lblSurgicalHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSurgicalHistory.Location = new Point(905, 32);
            lblSurgicalHistory.Name = "lblSurgicalHistory";
            lblSurgicalHistory.Size = new Size(139, 20);
            lblSurgicalHistory.TabIndex = 11;
            lblSurgicalHistory.Text = "Histórico cirúrgico";
            // 
            // txtSurgicalHistory
            // 
            txtSurgicalHistory.Location = new Point(905, 55);
            txtSurgicalHistory.Multiline = true;
            txtSurgicalHistory.Name = "txtSurgicalHistory";
            txtSurgicalHistory.ScrollBars = ScrollBars.Vertical;
            txtSurgicalHistory.Size = new Size(163, 130);
            txtSurgicalHistory.TabIndex = 10;
            // 
            // grpAddressInfo
            // 
            grpAddressInfo.Controls.Add(lblState);
            grpAddressInfo.Controls.Add(cmbState);
            grpAddressInfo.Controls.Add(lblCity);
            grpAddressInfo.Controls.Add(txtCity);
            grpAddressInfo.Controls.Add(lblDistrict);
            grpAddressInfo.Controls.Add(txtDistrict);
            grpAddressInfo.Controls.Add(lblPostalCode);
            grpAddressInfo.Controls.Add(txtPostalCode);
            grpAddressInfo.Controls.Add(lblStreetAddress);
            grpAddressInfo.Controls.Add(txtStreetAddress);
            grpAddressInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAddressInfo.Location = new Point(12, 583);
            grpAddressInfo.Name = "grpAddressInfo";
            grpAddressInfo.Size = new Size(1086, 110);
            grpAddressInfo.TabIndex = 3;
            grpAddressInfo.TabStop = false;
            grpAddressInfo.Text = "Endereço";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Location = new Point(20, 32);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(35, 20);
            lblPostalCode.TabIndex = 3;
            lblPostalCode.Text = "CEP";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(20, 55);
            txtPostalCode.Mask = "00000-000";
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(104, 27);
            txtPostalCode.TabIndex = 2;
            txtPostalCode.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStreetAddress.Location = new Point(141, 32);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(91, 20);
            lblStreetAddress.TabIndex = 1;
            lblStreetAddress.Text = "Logradouro";
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(141, 55);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(373, 27);
            txtStreetAddress.TabIndex = 0;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistrict.Location = new Point(534, 32);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(52, 20);
            lblDistrict.TabIndex = 5;
            lblDistrict.Text = "Bairro";
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(534, 55);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(175, 27);
            txtDistrict.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(726, 32);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(56, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "Cidade";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(726, 55);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(233, 27);
            txtCity.TabIndex = 6;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(981, 32);
            lblState.Name = "lblState";
            lblState.Size = new Size(31, 20);
            lblState.TabIndex = 9;
            lblState.Text = "UF";
            // 
            // cmbState
            // 
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbState.Location = new Point(981, 55);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(87, 28);
            cmbState.TabIndex = 8;
            // 
            // grpAnamnesis
            // 
            grpAnamnesis.Controls.Add(lblChiefComplaint);
            grpAnamnesis.Controls.Add(txtChiefComplaint);
            grpAnamnesis.Controls.Add(lblMedications);
            grpAnamnesis.Controls.Add(txtMedications);
            grpAnamnesis.Controls.Add(chkBleeder);
            grpAnamnesis.Controls.Add(chkPregnant);
            grpAnamnesis.Controls.Add(chkHypertension);
            grpAnamnesis.Controls.Add(chkDiabetes);
            grpAnamnesis.Controls.Add(chkHeartDisease);
            grpAnamnesis.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAnamnesis.Location = new Point(12, 699);
            grpAnamnesis.Name = "grpAnamnesis";
            grpAnamnesis.Size = new Size(1086, 194);
            grpAnamnesis.TabIndex = 4;
            grpAnamnesis.TabStop = false;
            grpAnamnesis.Text = "Anamnese";
            // 
            // chkHeartDisease
            // 
            chkHeartDisease.AutoSize = true;
            chkHeartDisease.Location = new Point(20, 35);
            chkHeartDisease.Name = "chkHeartDisease";
            chkHeartDisease.Size = new Size(138, 24);
            chkHeartDisease.TabIndex = 0;
            chkHeartDisease.Text = "Cardiopatia";
            chkHeartDisease.UseVisualStyleBackColor = true;
            // 
            // chkDiabetes
            // 
            chkDiabetes.AutoSize = true;
            chkDiabetes.Location = new Point(180, 35);
            chkDiabetes.Name = "chkDiabetes";
            chkDiabetes.Size = new Size(103, 24);
            chkDiabetes.TabIndex = 1;
            chkDiabetes.Text = "Diabetes";
            chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // chkHypertension
            // 
            chkHypertension.AutoSize = true;
            chkHypertension.Location = new Point(308, 35);
            chkHypertension.Name = "chkHypertension";
            chkHypertension.Size = new Size(128, 24);
            chkHypertension.TabIndex = 2;
            chkHypertension.Text = "Hipertensão";
            chkHypertension.UseVisualStyleBackColor = true;
            // 
            // chkPregnant
            // 
            chkPregnant.AutoSize = true;
            chkPregnant.Location = new Point(460, 35);
            chkPregnant.Name = "chkPregnant";
            chkPregnant.Size = new Size(106, 24);
            chkPregnant.TabIndex = 3;
            chkPregnant.Text = "Gestante";
            chkPregnant.UseVisualStyleBackColor = true;
            // 
            // chkBleeder
            // 
            chkBleeder.AutoSize = true;
            chkBleeder.Location = new Point(590, 35);
            chkBleeder.Name = "chkBleeder";
            chkBleeder.Size = new Size(157, 24);
            chkBleeder.TabIndex = 4;
            chkBleeder.Text = "Sangramento fácil";
            chkBleeder.UseVisualStyleBackColor = true;
            // 
            // lblMedications
            // 
            lblMedications.AutoSize = true;
            lblMedications.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedications.Location = new Point(20, 72);
            lblMedications.Name = "lblMedications";
            lblMedications.Size = new Size(192, 20);
            lblMedications.TabIndex = 6;
            lblMedications.Text = "Medicações de uso contínuo";
            // 
            // txtMedications
            // 
            txtMedications.Location = new Point(20, 95);
            txtMedications.Multiline = true;
            txtMedications.Name = "txtMedications";
            txtMedications.ScrollBars = ScrollBars.Vertical;
            txtMedications.Size = new Size(510, 80);
            txtMedications.TabIndex = 5;
            // 
            // lblChiefComplaint
            // 
            lblChiefComplaint.AutoSize = true;
            lblChiefComplaint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiefComplaint.Location = new Point(552, 72);
            lblChiefComplaint.Name = "lblChiefComplaint";
            lblChiefComplaint.Size = new Size(141, 20);
            lblChiefComplaint.TabIndex = 8;
            lblChiefComplaint.Text = "Queixa principal";
            // 
            // txtChiefComplaint
            // 
            txtChiefComplaint.Location = new Point(552, 95);
            txtChiefComplaint.Multiline = true;
            txtChiefComplaint.Name = "txtChiefComplaint";
            txtChiefComplaint.ScrollBars = ScrollBars.Vertical;
            txtChiefComplaint.Size = new Size(512, 80);
            txtChiefComplaint.TabIndex = 7;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Controls.Add(btnSave);
            pnlActions.Controls.Add(chkIsActive);
            pnlActions.Controls.Add(lblFormStatus);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 906);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1110, 92);
            pnlActions.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(20, 18);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(129, 24);
            chkIsActive.TabIndex = 0;
            chkIsActive.Text = "Cadastro ativo";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblFormStatus
            // 
            lblFormStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormStatus.Location = new Point(20, 50);
            lblFormStatus.Name = "lblFormStatus";
            lblFormStatus.Size = new Size(650, 24);
            lblFormStatus.TabIndex = 1;
            lblFormStatus.Text = "Novo cadastro";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(914, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "Salvar";
            btnSave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(1008, 26);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PatientRegistrationControl
            // 
            BackColor = System.Drawing.Color.White;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(grpAnamnesis);
            Controls.Add(pnlActions);
            Controls.Add(grpAddressInfo);
            Controls.Add(grpMedicalInfo);
            Controls.Add(grpContactInfo);
            Controls.Add(grpPersonalInfo);
            Name = "PatientRegistrationControl";
            Size = new Size(1110, 998);
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpContactInfo.ResumeLayout(false);
            grpContactInfo.PerformLayout();
            grpMedicalInfo.ResumeLayout(false);
            grpMedicalInfo.PerformLayout();
            grpAddressInfo.ResumeLayout(false);
            grpAddressInfo.PerformLayout();
            grpAnamnesis.ResumeLayout(false);
            grpAnamnesis.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpPersonalInfo;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblTaxId;
        private MaskedTextBox txtTaxId;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblIdentityCard;
        private TextBox txtIdentityCard;
        private GroupBox grpContactInfo;
        private Label lblMobilePhone;
        private MaskedTextBox txtMobilePhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmergencyContactName;
        private TextBox txtEmergencyContactName;
        private Label lblEmergencyPhone;
        private MaskedTextBox txtEmergencyPhone;
        private GroupBox grpMedicalInfo;
        private Label lblDrugAllergies;
        private TextBox txtDrugAllergies;
        private Label lblMedicalNotes;
        private TextBox txtMedicalNotes;
        private Label lblInsuranceProvider;
        private ComboBox cmbInsuranceProvider;
        private Label lblInsurancePolicyNumber;
        private TextBox txtInsurancePolicyNumber;
        private Label lblSurgicalHistory;
        private TextBox txtSurgicalHistory;
        private GroupBox grpAddressInfo;
        private Label lblPostalCode;
        private MaskedTextBox txtPostalCode;
        private Label lblStreetAddress;
        private TextBox txtStreetAddress;
        private Label lblDistrict;
        private TextBox txtDistrict;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblState;
        private ComboBox cmbState;
        private GroupBox grpAnamnesis;
        private Label lblChiefComplaint;
        private TextBox txtChiefComplaint;
        private Label lblMedications;
        private TextBox txtMedications;
        private CheckBox chkBleeder;
        private CheckBox chkPregnant;
        private CheckBox chkHypertension;
        private CheckBox chkDiabetes;
        private CheckBox chkHeartDisease;
        private Panel pnlActions;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkIsActive;
        private Label lblFormStatus;
    }
}



