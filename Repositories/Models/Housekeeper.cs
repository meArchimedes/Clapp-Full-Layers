using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Housekeeper:User
    {
        public int UserId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int Id { get; set; }

        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
