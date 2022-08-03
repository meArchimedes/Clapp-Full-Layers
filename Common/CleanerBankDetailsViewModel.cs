using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CleanerBankDetailsViewModel
    {
        public partial class CleanerBankDetail
        {
            public CleanerBankDetail()
            {
                Cleaners = new HashSet<Cleaner>();
            }

            public int BankDetailsId { get; set; }
            public string Bank { get; set; } = null!;
            public long Branch { get; set; }
            public long? RoutingNo { get; set; }
            public string AccountName { get; set; } = null!;
            public int AddressId { get; set; }

            public virtual ICollection<Cleaner> Cleaners { get; set; }
        }
    }
}
