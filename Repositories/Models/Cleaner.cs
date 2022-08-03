using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Cleaner:User
    {
        public int BankDetailsId { get; set; }
        public decimal Price { get; set; }
        public int? Perfectionism { get; set; }
        public int? Efficiency { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }

        public virtual CleanerBankDetail BankDetails { get; set; } = null!;
    }
}
