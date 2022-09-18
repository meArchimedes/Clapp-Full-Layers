
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AddressViewModel
    {
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
