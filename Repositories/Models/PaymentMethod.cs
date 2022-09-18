using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Users = new HashSet<User>();
        }

        public int PaymentMethodId { get; set; }
        public int? PayPalId { get; set; }
        public int? GooglePayId { get; set; }
        public int? CreditCardId { get; set; }
        public int? CheckingAccountId { get; set; }

        public virtual CreditCard? CreditCard { get; set; }
        public virtual GooglePay? GooglePay { get; set; }
        public virtual PayPal? PayPal { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
