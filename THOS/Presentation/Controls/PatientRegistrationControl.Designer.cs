namespace THOS.Controls
{
    partial class PatientRegistrationControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            grpPersonalInfo = new GroupBox();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtTaxId = new MaskedTextBox();
            lblTaxId = new Label();
            dtBirthDate = new DateTimePicker();
            lblBirthDate = new Label();
            cmbGender = new ComboBox();
            label1 = new Label();
            grpContactInfo = new GroupBox();
            lblMobilePhone = new Label();
            txtMobilePhone = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmergencyContactName = new Label();
            txtEmergencyContactName = new TextBox();
            lblEmergencyPhone = new Label();
            txtEmergencyPhone = new MaskedTextBox();
            groupBox1 = new GroupBox();
            lblInsuranceProvider = new Label();
            cmbInsuranceProvider = new ComboBox();
            lblInsurancePolicyNumber = new Label();
            txtInsurancePolicyNumber = new MaskedTextBox();
            lblDrugAllergies = new Label();
            txtDrugAllergies = new TextBox();
            lblMedicalNotes = new Label();
            txtMedicalNotes = new TextBox();
            groupBox2 = new GroupBox();
            lblPostalCode = new Label();
            txtPostalCode = new MaskedTextBox();
            lblStreetAddress = new Label();
            txtStreetAddress = new TextBox();
            lblDistrict = new Label();
            txtDistrict = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            cmbState = new ComboBox();
            lblState = new Label();
            pnlActions = new Panel();
            lblFormStatus = new Label();
            chkIsActive = new CheckBox();
            btnSalvar = new Button();
            btnCancel = new Button();
            grpPersonalInfo.SuspendLayout();
            grpContactInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(label1);
            grpPersonalInfo.Controls.Add(cmbGender);
            grpPersonalInfo.Controls.Add(lblBirthDate);
            grpPersonalInfo.Controls.Add(dtBirthDate);
            grpPersonalInfo.Controls.Add(lblTaxId);
            grpPersonalInfo.Controls.Add(txtTaxId);
            grpPersonalInfo.Controls.Add(lblFullName);
            grpPersonalInfo.Controls.Add(txtFullName);
            grpPersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPersonalInfo.Location = new Point(3, 3);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(980, 201);
            grpPersonalInfo.TabIndex = 0;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Details";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(19, 56);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(326, 27);
            txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(19, 33);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(124, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Nome Completo";
            // 
            // txtTaxId
            // 
            txtTaxId.Location = new Point(405, 56);
            txtTaxId.Mask = "000.000.000-00";
            txtTaxId.Name = "txtTaxId";
            txtTaxId.Size = new Size(327, 27);
            txtTaxId.TabIndex = 2;
            // 
            // lblTaxId
            // 
            lblTaxId.AutoSize = true;
            lblTaxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxId.Location = new Point(405, 33);
            lblTaxId.Name = "lblTaxId";
            lblTaxId.Size = new Size(94, 20);
            lblTaxId.TabIndex = 3;
            lblTaxId.Text = "CPF / Tax ID";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(802, 56);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(144, 27);
            dtBirthDate.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthDate.Location = new Point(802, 33);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(151, 20);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Data de Nascimento";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
            cmbGender.Location = new Point(19, 132);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 109);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 7;
            label1.Text = "Gênero";
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
            grpContactInfo.Location = new Point(3, 210);
            grpContactInfo.Name = "grpContactInfo";
            grpContactInfo.Size = new Size(980, 198);
            grpContactInfo.TabIndex = 1;
            grpContactInfo.TabStop = false;
            grpContactInfo.Text = "Contact Information";
            // 
            // lblMobilePhone
            // 
            lblMobilePhone.AutoSize = true;
            lblMobilePhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMobilePhone.Location = new Point(19, 33);
            lblMobilePhone.Name = "lblMobilePhone";
            lblMobilePhone.Size = new Size(121, 20);
            lblMobilePhone.TabIndex = 3;
            lblMobilePhone.Text = "Telefone Celular";
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(19, 56);
            txtMobilePhone.Mask = "(00) 00000-0000";
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(327, 27);
            txtMobilePhone.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(361, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(361, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblEmergencyContactName
            // 
            lblEmergencyContactName.AutoSize = true;
            lblEmergencyContactName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyContactName.Location = new Point(361, 106);
            lblEmergencyContactName.Name = "lblEmergencyContactName";
            lblEmergencyContactName.Size = new Size(238, 20);
            lblEmergencyContactName.TabIndex = 5;
            lblEmergencyContactName.Text = "Nome do contato de emergencia";
            // 
            // txtEmergencyContactName
            // 
            txtEmergencyContactName.Location = new Point(361, 129);
            txtEmergencyContactName.Name = "txtEmergencyContactName";
            txtEmergencyContactName.Size = new Size(326, 27);
            txtEmergencyContactName.TabIndex = 4;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.AutoSize = true;
            lblEmergencyPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyPhone.Location = new Point(19, 106);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(175, 20);
            lblEmergencyPhone.TabIndex = 7;
            lblEmergencyPhone.Text = "Telefone de Emergência";
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Location = new Point(19, 129);
            txtEmergencyPhone.Mask = "(00) 00000-0000";
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(327, 27);
            txtEmergencyPhone.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMedicalNotes);
            groupBox1.Controls.Add(txtMedicalNotes);
            groupBox1.Controls.Add(lblInsuranceProvider);
            groupBox1.Controls.Add(cmbInsuranceProvider);
            groupBox1.Controls.Add(lblInsurancePolicyNumber);
            groupBox1.Controls.Add(txtInsurancePolicyNumber);
            groupBox1.Controls.Add(lblDrugAllergies);
            groupBox1.Controls.Add(txtDrugAllergies);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(8, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(980, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medical / Dental Context";
            // 
            // lblInsuranceProvider
            // 
            lblInsuranceProvider.AutoSize = true;
            lblInsuranceProvider.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsuranceProvider.Location = new Point(746, 33);
            lblInsuranceProvider.Name = "lblInsuranceProvider";
            lblInsuranceProvider.Size = new Size(195, 20);
            lblInsuranceProvider.TabIndex = 7;
            lblInsuranceProvider.Text = "Convênio / Plano de Saúde";
            // 
            // cmbInsuranceProvider
            // 
            cmbInsuranceProvider.FormattingEnabled = true;
            cmbInsuranceProvider.Items.AddRange(new object[] { "Private" });
            cmbInsuranceProvider.Location = new Point(758, 56);
            cmbInsuranceProvider.Name = "cmbInsuranceProvider";
            cmbInsuranceProvider.Size = new Size(174, 28);
            cmbInsuranceProvider.TabIndex = 6;
            // 
            // lblInsurancePolicyNumber
            // 
            lblInsurancePolicyNumber.AutoSize = true;
            lblInsurancePolicyNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsurancePolicyNumber.Location = new Point(758, 104);
            lblInsurancePolicyNumber.Name = "lblInsurancePolicyNumber";
            lblInsurancePolicyNumber.Size = new Size(147, 20);
            lblInsurancePolicyNumber.TabIndex = 3;
            lblInsurancePolicyNumber.Text = "Número da Carteira";
            // 
            // txtInsurancePolicyNumber
            // 
            txtInsurancePolicyNumber.Location = new Point(746, 127);
            txtInsurancePolicyNumber.Name = "txtInsurancePolicyNumber";
            txtInsurancePolicyNumber.Size = new Size(196, 27);
            txtInsurancePolicyNumber.TabIndex = 2;
            // 
            // lblDrugAllergies
            // 
            lblDrugAllergies.AutoSize = true;
            lblDrugAllergies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrugAllergies.Location = new Point(19, 33);
            lblDrugAllergies.Name = "lblDrugAllergies";
            lblDrugAllergies.Size = new Size(178, 20);
            lblDrugAllergies.TabIndex = 1;
            lblDrugAllergies.Text = "Alergia a Medicamentos";
            // 
            // txtDrugAllergies
            // 
            txtDrugAllergies.Location = new Point(19, 56);
            txtDrugAllergies.Multiline = true;
            txtDrugAllergies.Name = "txtDrugAllergies";
            txtDrugAllergies.Size = new Size(326, 129);
            txtDrugAllergies.TabIndex = 0;
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicalNotes.Location = new Point(356, 33);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(141, 20);
            lblMedicalNotes.TabIndex = 9;
            lblMedicalNotes.Text = "Condições Médicas";
            // 
            // txtMedicalNotes
            // 
            txtMedicalNotes.Location = new Point(356, 56);
            txtMedicalNotes.Multiline = true;
            txtMedicalNotes.Name = "txtMedicalNotes";
            txtMedicalNotes.Size = new Size(326, 129);
            txtMedicalNotes.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblState);
            groupBox2.Controls.Add(cmbState);
            groupBox2.Controls.Add(lblCity);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(lblDistrict);
            groupBox2.Controls.Add(txtDistrict);
            groupBox2.Controls.Add(lblPostalCode);
            groupBox2.Controls.Add(txtPostalCode);
            groupBox2.Controls.Add(lblStreetAddress);
            groupBox2.Controls.Add(txtStreetAddress);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 630);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(980, 105);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contact Information";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Location = new Point(19, 33);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(35, 20);
            lblPostalCode.TabIndex = 3;
            lblPostalCode.Text = "CEP";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(19, 56);
            txtPostalCode.Mask = "00000-000";
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(101, 27);
            txtPostalCode.TabIndex = 2;
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStreetAddress.Location = new Point(138, 33);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(91, 20);
            lblStreetAddress.TabIndex = 1;
            lblStreetAddress.Text = "Logradouro";
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(138, 56);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(326, 27);
            txtStreetAddress.TabIndex = 0;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistrict.Location = new Point(479, 33);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(52, 20);
            lblDistrict.TabIndex = 5;
            lblDistrict.Text = "Bairro";
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(479, 56);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(148, 27);
            txtDistrict.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(651, 33);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(56, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "Cidade";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(651, 56);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(195, 27);
            txtCity.TabIndex = 6;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "SP", "RJ", "MG" });
            cmbState.Location = new Point(871, 56);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(91, 28);
            cmbState.TabIndex = 8;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(871, 33);
            lblState.Name = "lblState";
            lblState.Size = new Size(82, 20);
            lblState.TabIndex = 9;
            lblState.Text = "Estado/UF";
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Controls.Add(btnSalvar);
            pnlActions.Controls.Add(chkIsActive);
            pnlActions.Controls.Add(lblFormStatus);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 777);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(991, 96);
            pnlActions.TabIndex = 4;
            // 
            // lblFormStatus
            // 
            lblFormStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormStatus.Location = new Point(3, 67);
            lblFormStatus.Name = "lblFormStatus";
            lblFormStatus.Size = new Size(555, 20);
            lblFormStatus.TabIndex = 10;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(18, 32);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(156, 24);
            chkIsActive.TabIndex = 11;
            chkIsActive.Text = "Status do Cadastro";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(789, 29);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(889, 29);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PatientRegistrationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlActions);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpContactInfo);
            Controls.Add(grpPersonalInfo);
            Name = "PatientRegistrationControl";
            Size = new Size(991, 873);
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpContactInfo.ResumeLayout(false);
            grpContactInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonalInfo;
        private TextBox txtFullName;
        private Label lblTaxId;
        private MaskedTextBox txtTaxId;
        private Label lblFullName;
        private Label lblBirthDate;
        private DateTimePicker dtBirthDate;
        private Label label1;
        private ComboBox cmbGender;
        private GroupBox grpContactInfo;
        private Label lblMobilePhone;
        private MaskedTextBox txtMobilePhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmergencyPhone;
        private MaskedTextBox txtEmergencyPhone;
        private Label lblEmergencyContactName;
        private TextBox txtEmergencyContactName;
        private GroupBox groupBox1;
        private Label lblInsuranceProvider;
        private ComboBox cmbInsuranceProvider;
        private DateTimePicker dateTimePicker1;
        private Label lblInsurancePolicyNumber;
        private MaskedTextBox txtInsurancePolicyNumber;
        private Label lblDrugAllergies;
        private TextBox txtDrugAllergies;
        private Label lblMedicalNotes;
        private TextBox txtMedicalNotes;
        private GroupBox groupBox2;
        private Label lblPostalCode;
        private MaskedTextBox txtPostalCode;
        private Label lblStreetAddress;
        private TextBox txtStreetAddress;
        private Label lblDistrict;
        private TextBox txtDistrict;
        private Label lblState;
        private ComboBox cmbState;
        private Label lblCity;
        private TextBox txtCity;
        private Panel pnlActions;
        private Button btnCancel;
        private Button btnSalvar;
        private CheckBox chkIsActive;
        private Label lblFormStatus;
    }
}
