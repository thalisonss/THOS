using System;

namespace THOS.Client.Domain.Entities
{
    public class LocalAnamnesis : BaseEntity
    {
        public Guid PatientId { get; set; }
        public virtual LocalPatient? Patient { get; set; }

        public bool HasHeartDisease { get; set; }
        public bool HasDiabetes { get; set; }
        public bool HasHypertension { get; set; }
        public bool IsPregnant { get; set; }
        public bool IsBleeder { get; set; } // Problemas de coagulação/hemorragia

        public string ContinuousMedications { get; set; } = string.Empty; // Remédios de uso contínuo
        public string SurgicalHistory { get; set; } = string.Empty; // Cirurgias anteriores
        public string ChiefComplaint { get; set; } = string.Empty; // Queixa principal do paciente
    }
}