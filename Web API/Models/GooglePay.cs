using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class GooglePay
    {
        public GooglePay()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public int GooglePayId { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
