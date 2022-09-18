using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class Address
    {
        public Address()
        {
            AddressUsers = new HashSet<AddressUser>();
        }

        public int AddressId { get; set; }
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Zip { get; set; } = null!;
        public string? State { get; set; }

        public virtual ICollection<AddressUser> AddressUsers { get; set; }
    }
}
