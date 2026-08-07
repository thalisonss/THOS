using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.IO;
using THOS.Client.Domain.Entities;

namespace THOS.Client.Infrastructure.Data
{
    public class ThosContext : DbContext
    {
        public DbSet<LocalPatient> Patients { get; set; } = null!;
        public DbSet<LocalAnamnesis> Anamnesis { get; set; } = null!;
        public DbSet<LocalUser> Users { get; set; } = null!;
        public DbSet<LocalProfile> Profiles { get; set; } = null!;
        public DbSet<LocalUserProfile> UserProfiles { get; set; } = null!;

        public ThosContext()
        {
        }

        public ThosContext(DbContextOptions<ThosContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string thosFolder = Path.Combine(appDataFolder, "THOS");

                if (!Directory.Exists(thosFolder))
                {
                    Directory.CreateDirectory(thosFolder);
                }

                string dbPath = Path.Combine(thosFolder, "thos_local.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<Guid>()
                .HaveConversion(typeof(GuidLowerCaseConverter));
            configurationBuilder.Properties<Guid?>()
                .HaveConversion(typeof(NullableGuidLowerCaseConverter));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==========================================
            // MAPEAMENTO DA TABELA: THOS_Patient
            // ==========================================
            modelBuilder.Entity<LocalPatient>(entity =>
            {
                // Nome do Prefixo da Tabela
                entity.ToTable("THOS_Patient");

                // Mapeamento das Colunas em Nota��o H�ngara
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Id).HasColumnName("cIDPatient");

                // Dados Pessoais
                entity.Property(p => p.FullName).HasColumnName("stFullName").IsRequired().HasMaxLength(150);
                entity.Property(p => p.TaxId).HasColumnName("stTaxId").HasMaxLength(20);
                entity.Property(p => p.IdentityCard).HasColumnName("stIdentityCard").HasMaxLength(20);
                entity.Property(p => p.BirthDate).HasColumnName("dtBirthDate");
                entity.Property(p => p.Gender).HasColumnName("stGender").HasMaxLength(20);

                // Contato
                entity.Property(p => p.MobilePhone).HasColumnName("stMobilePhone").HasMaxLength(20);
                entity.Property(p => p.Email).HasColumnName("stEmail").HasMaxLength(100);
                entity.Property(p => p.EmergencyContactName).HasColumnName("stEmergencyContactName").HasMaxLength(100);
                entity.Property(p => p.EmergencyPhone).HasColumnName("stEmergencyPhone").HasMaxLength(20);

                // Conv�nio / Plano
                entity.Property(p => p.InsuranceProvider).HasColumnName("stInsuranceProvider").HasMaxLength(50);
                entity.Property(p => p.InsurancePolicyNumber).HasColumnName("stInsurancePolicyNumber").HasMaxLength(50);

                // Alertas M�dicos
                entity.Property(p => p.DrugAllergies).HasColumnName("stDrugAllergies");
                entity.Property(p => p.MedicalNotes).HasColumnName("stMedicalNotes");

                // Endere�o
                entity.Property(p => p.PostalCode).HasColumnName("stPostalCode").HasMaxLength(10);
                entity.Property(p => p.StreetAddress).HasColumnName("stStreetAddress").HasMaxLength(200);
                entity.Property(p => p.District).HasColumnName("stDistrict").HasMaxLength(100);
                entity.Property(p => p.City).HasColumnName("stCity").HasMaxLength(100);
                entity.Property(p => p.State).HasColumnName("stState").HasMaxLength(2);

                // Controle THOS Sync & Auditoria
                entity.Property(p => p.IsSynced).HasColumnName("bIsSynced");
                entity.Property(p => p.IsActive).HasColumnName("bIsActive");
                entity.Property(p => p.CreatedAt).HasColumnName("dtCreatedAt");
                entity.Property(p => p.UpdatedAt).HasColumnName("dtUpdatedAt");

                // �ndices
                entity.HasIndex(p => p.FullName).HasDatabaseName("IX_THOS_Patient_stFullName");
                entity.HasIndex(p => p.TaxId).HasDatabaseName("IX_THOS_Patient_stTaxId");
            });

            // ==========================================
            // MAPEAMENTO DA TABELA: THOS_Anamnesis
            // ==========================================
            modelBuilder.Entity<LocalAnamnesis>(entity =>
            {
                entity.ToTable("THOS_Anamnesis");

                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id).HasColumnName("cIDAnamnesis");
                entity.Property(a => a.PatientId).HasColumnName("cIDPatient");

                entity.Property(a => a.HasHeartDisease).HasColumnName("bHasHeartDisease");
                entity.Property(a => a.HasDiabetes).HasColumnName("bHasDiabetes");
                entity.Property(a => a.HasHypertension).HasColumnName("bHasHypertension");
                entity.Property(a => a.IsPregnant).HasColumnName("bIsPregnant");
                entity.Property(a => a.IsBleeder).HasColumnName("bIsBleeder");

                entity.Property(a => a.ContinuousMedications).HasColumnName("stContinuousMedications");
                entity.Property(a => a.SurgicalHistory).HasColumnName("stSurgicalHistory");
                entity.Property(a => a.ChiefComplaint).HasColumnName("stChiefComplaint");

                entity.Property(a => a.IsSynced).HasColumnName("bIsSynced");
                entity.Property(a => a.IsActive).HasColumnName("bIsActive");
                entity.Property(a => a.CreatedAt).HasColumnName("dtCreatedAt");
                entity.Property(a => a.UpdatedAt).HasColumnName("dtUpdatedAt");
            });
            // Users
            modelBuilder.Entity<LocalUser>(entity => {
                entity.ToTable("THOS_User");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("cIDUser");
                entity.Property(e => e.FullName).HasColumnName("stFullName").IsRequired().HasMaxLength(150);
                entity.Property(e => e.Login).HasColumnName("stLogin").IsRequired().HasMaxLength(50);
                                entity.Property(e => e.PasswordHash).HasColumnName("stPasswordHash").IsRequired().HasMaxLength(255);
                entity.Property(e => e.ProfileLastAccessId).HasColumnName("cIDProfileLastAccess");
                entity.Property(e => e.IsSynced).HasColumnName("bIsSynced");
                entity.Property(e => e.IsActive).HasColumnName("bIsActive");
                entity.Property(e => e.CreatedAt).HasColumnName("dtCreatedAt");
                entity.Property(e => e.UpdatedAt).HasColumnName("dtUpdatedAt");
            });

            // Roles
            modelBuilder.Entity<LocalProfile>(entity => {
                entity.ToTable("THOS_Profile");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("cIDProfile");
                entity.Property(e => e.Name).HasColumnName("stName").IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasColumnName("stDescription").HasMaxLength(200);
                entity.Property(e => e.IsSynced).HasColumnName("bIsSynced");
                entity.Property(e => e.IsActive).HasColumnName("bIsActive");
                entity.Property(e => e.CreatedAt).HasColumnName("dtCreatedAt");
                entity.Property(e => e.UpdatedAt).HasColumnName("dtUpdatedAt");
            });

            // User Profiles
            modelBuilder.Entity<LocalUserProfile>(entity => {
                entity.ToTable("THOS_UserProfile");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("cIDUserProfile");
                entity.Property(e => e.UserId).HasColumnName("cIDUser");
                entity.Property(e => e.ProfileId).HasColumnName("cIDProfile");
                entity.Property(e => e.IsSynced).HasColumnName("bIsSynced");
                entity.Property(e => e.IsActive).HasColumnName("bIsActive");
                entity.Property(e => e.CreatedAt).HasColumnName("dtCreatedAt");
                entity.Property(e => e.UpdatedAt).HasColumnName("dtUpdatedAt");

                entity.HasOne(up => up.User).WithMany(u => u.Profiles).HasForeignKey(up => up.UserId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(up => up.Profile).WithMany(p => p.Users).HasForeignKey(up => up.ProfileId).OnDelete(DeleteBehavior.Restrict);
            });
        }

        private sealed class GuidLowerCaseConverter : ValueConverter<Guid, string>
        {
            public GuidLowerCaseConverter()
                : base(v => v.ToString("D").ToLowerInvariant(), v => Guid.Parse(v))
            {
            }
        }

        private sealed class NullableGuidLowerCaseConverter : ValueConverter<Guid?, string?>
        {
            public NullableGuidLowerCaseConverter()
                : base(
                    v => v.HasValue ? v.Value.ToString("D").ToLowerInvariant() : null,
                    v => string.IsNullOrWhiteSpace(v) ? null : Guid.Parse(v))
            {
            }
        }
    }
}



