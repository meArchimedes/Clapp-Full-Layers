using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class PayPal
    {
        public PayPal()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public int PayPalId { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
