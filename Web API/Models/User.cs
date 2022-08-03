using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            Housekeepers = new HashSet<Housekeeper>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int AddressId { get; set; }
        public string? Email { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Housekeeper> Housekeepers { get; set; }
    }
}
