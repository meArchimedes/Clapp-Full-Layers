using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class AddressUser
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
