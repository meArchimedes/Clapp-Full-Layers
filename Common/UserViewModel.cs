using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Repositories.Models;

namespace Common
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public int? PaymentId { get; set; }

    }
}
