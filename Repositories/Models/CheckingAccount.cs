using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class CheckingAccount
    {
        public long RoutingNo { get; set; }
        public long AccountNo { get; set; }
        public int CheckingAccountId { get; set; }
    }
}
