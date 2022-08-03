using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<User>();
        }

        public int AddressId { get; set; }
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Zip { get; set; } = null!;
        public string? State { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
