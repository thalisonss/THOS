using System;
using System.Collections.Generic;
using THOS.Client.Domain.Entities;

namespace THOS.Client.Domain.Entities
{
    public class LocalPatient : BaseEntity
    {
        // --- DADOS PESSOAIS ---
        public string FullName { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty; // CPF
        public string IdentityCard { get; set; } = string.Empty; // RG
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = "PreferNotToSay";

        // --- CONTATO ---
        public string MobilePhone { get; set; } = string.Empty; // WhatsApp
        public string Email { get; set; } = string.Empty;
        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyPhone { get; set; } = string.Empty;

        // --- PLANO DE SAÚDE / CONVÊNIO ODONTOLÓGICO ---
        public string InsuranceProvider { get; set; } = "Private"; // Particular ou Nome do Convênio
        public string InsurancePolicyNumber { get; set; } = string.Empty;

        // --- ALERTAS MÉDICOS DE RÁPIDO ACESSO ---
        public string DrugAllergies { get; set; } = string.Empty; // Ex: Penicilina, Anestésicos
        public string MedicalNotes { get; set; } = string.Empty; // Ex: Hipertensão, Diabetes, Marcapasso

        // --- ENDEREÇO ---
        public string PostalCode { get; set; } = string.Empty; // CEP
        public string StreetAddress { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;

        // --- RELACIONAMENTOS (OPCIONAIS PARA PRÓXIMAS FASES) ---
        public virtual ICollection<LocalAnamnesis> AnamnesisHistory { get; set; } = new List<LocalAnamnesis>();
    }
}