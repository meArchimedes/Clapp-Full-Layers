using System;
using System.Collections.Generic;

namespace Web_API.Models
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
