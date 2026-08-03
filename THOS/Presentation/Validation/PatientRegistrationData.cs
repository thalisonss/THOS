namespace THOS.Client.Presentation.Validation
{
    /// <summary>
    /// Representa um snapshot dos dados da tela de cadastro.
    /// Isso evita que a validação dependa diretamente dos controles da UI.
    /// </summary>
    public sealed record PatientRegistrationData(
        string FullName,
        string TaxId,
        string IdentityCard,
        DateTime? BirthDate,
        string Gender,
        string MobilePhone,
        string Email,
        string EmergencyContactName,
        string EmergencyPhone,
        string InsuranceProvider,
        string InsurancePolicyNumber,
        string DrugAllergies,
        string MedicalNotes,
        string PostalCode,
        string StreetAddress,
        string District,
        string City,
        string State,
        bool HasHeartDisease,
        bool HasDiabetes,
        bool HasHypertension,
        bool IsPregnant,
        bool IsBleeder,
        string ContinuousMedications,
        string SurgicalHistory,
        string ChiefComplaint,
        bool IsActive);
}
