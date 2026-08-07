using System;
using System.Collections.Generic;

namespace THOS.Client.Domain.Entities
{
    public class LocalUser : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
                public string PasswordHash { get; set; } = string.Empty;

        public Guid? ProfileLastAccessId { get; set; }

        public virtual ICollection<LocalUserProfile> Profiles { get; set; } = new List<LocalUserProfile>();
    }
}
