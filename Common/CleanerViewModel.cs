using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CleanerViewModel : UserViewModel
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
