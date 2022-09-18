using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class User
    {
        public User()
        {
            AddressUsers = new HashSet<AddressUser>();
        }

        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public int? PaymentId { get; set; }

        public virtual PaymentMethod? Payment { get; set; }
        public virtual Cleaner? Cleaner { get; set; } = null!;
        public virtual Housekeeper? Housekeeper { get; set; } = null!;
        public virtual ICollection<AddressUser>? AddressUsers { get; set; }
    }
}
