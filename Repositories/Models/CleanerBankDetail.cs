using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class CleanerBankDetail
    {
        public int BankDetailsId { get; set; }
        public string Bank { get; set; } = null!;
        public long Branch { get; set; }
        public long? RoutingNo { get; set; }
        public string AccountName { get; set; } = null!;

        public virtual Cleaner BankDetails { get; set; } = null!;
    }
}
