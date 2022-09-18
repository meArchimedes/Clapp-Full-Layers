using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class Cleaner
    {
        public decimal Price { get; set; }
        public double? Perfectionism { get; set; }
        public double? Efficiency { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }

        public virtual User IdNavigation { get; set; } = null!;
        public virtual CleanerBankDetail CleanerBankDetail { get; set; } = null!;
    }
}
