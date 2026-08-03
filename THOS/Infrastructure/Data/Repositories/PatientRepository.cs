using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using THOS.Client.Domain.Entities;

namespace THOS.Client.Infrastructure.Data.Repositories
{
    public class PatientRepository
    {
        /// <summary>
        /// Salva ou Atualiza o Paciente e a sua Anamnese no SQLite
        /// </summary>
        public void Save(LocalPatient patient, LocalAnamnesis? anamnesis = null)
        {
            using var db = new ThosContext();

            // --- 1. GRAVAÇÃO DO PACIENTE ---
            patient.IsSynced = false;
            patient.UpdatedAt = DateTime.UtcNow;

            bool patientExists = db.Patients.Any(p => p.Id == patient.Id);

            if (!patientExists)
            {
                db.Patients.Add(patient);
            }
            else
            {
                db.Patients.Update(patient);
            }

            // --- 2. GRAVAÇÃO DA ANAMNESE (Se for informada) ---
            if (anamnesis != null)
            {
                anamnesis.PatientId = patient.Id; // Vincula a Chave Estrangeira cIDPatient
                anamnesis.IsSynced = false;
                anamnesis.UpdatedAt = DateTime.UtcNow;

                bool anamnesisExists = db.Anamnesis.Any(a => a.Id == anamnesis.Id || a.PatientId == patient.Id);

                if (!anamnesisExists)
                {
                    db.Anamnesis.Add(anamnesis);
                }
                else
                {
                    db.Anamnesis.Update(anamnesis);
                }
            }

            db.SaveChanges(); // Salva Paciente + Anamnese numa única transação
        }

        /// <summary>
        /// Busca a Anamnese vinculada a um paciente específico
        /// </summary>
        public LocalAnamnesis? GetAnamnesisByPatientId(Guid patientId)
        {
            using var db = new ThosContext();
            return db.Anamnesis.FirstOrDefault(a => a.PatientId == patientId && a.IsActive);
        }

        public List<LocalPatient> Search(string searchTerm = "")
        {
            using var db = new ThosContext();

            var query = db.Patients.Where(p => p.IsActive);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string term = searchTerm.Trim().ToLower();
                query = query.Where(p => p.FullName.ToLower().Contains(term) || p.TaxId.Contains(term));
            }

            return query.OrderBy(p => p.FullName).ToList();
        }
    }
}