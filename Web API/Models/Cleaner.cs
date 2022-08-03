using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Cleaner
    {
        public int BankDetailsId { get; set; }
        public decimal Price { get; set; }
        public double? Perfectionism { get; set; }
        public double? Efficiency { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }

        public virtual CleanerBankDetail BankDetails { get; set; } = null!;
    }
}
