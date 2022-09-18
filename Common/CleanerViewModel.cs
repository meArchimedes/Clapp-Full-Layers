using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CleanerViewModel : UserViewModel
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
