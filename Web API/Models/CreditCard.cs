using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public long CardNo { get; set; }
        public DateTime Exp { get; set; }
        public string Cvv { get; set; } = null!;
        public string CardHolder { get; set; } = null!;
        public int? UserId { get; set; }
        public int CreditCardId { get; set; }
        public bool? Response { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
