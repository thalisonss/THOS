using System;

namespace THOS.Client.Domain.Entities
{
    public class LocalUserProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual LocalUser? User { get; set; }

        public Guid ProfileId { get; set; }
        public virtual LocalProfile? Profile { get; set; }
    }
}