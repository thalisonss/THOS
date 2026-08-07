using System;
using System.Collections.Generic;

namespace THOS.Client.Domain.Entities
{
    public class LocalProfile : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<LocalUserProfile> Users { get; set; } = new List<LocalUserProfile>();
    }
}