using System;

namespace THOS.Client.Domain.Entities
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Chave Primária em UUID v4 gerada no cliente (Garante não-colisão no Sync com o PostgreSQL remoto).
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Indica se o registro local foi sincronizado com o servidor na nuvem.
        /// </summary>
        public bool IsSynced { get; set; } = false;

        /// <summary>
        /// Soft Delete: Indica se o registro está ativo no sistema.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Data/Hora UTC de criação do registro.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Data/Hora UTC da última modificação (usado para o Sync Incremental / Delta Sync).
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}