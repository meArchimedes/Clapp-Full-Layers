using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Housekeepers = new HashSet<Housekeeper>();
        }

        public int PaymentMethodId { get; set; }
        public int? PayPalId { get; set; }
        public int? GooglePayId { get; set; }
        public int? CreditCardId { get; set; }
        public int? CheckingAccountId { get; set; }

        public virtual CreditCard? CreditCard { get; set; }
        public virtual GooglePay? GooglePay { get; set; }
        public virtual PayPal? PayPal { get; set; }
        public virtual ICollection<Housekeeper> Housekeepers { get; set; }
    }
}
