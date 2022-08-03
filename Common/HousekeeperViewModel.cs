using Repositories.Models;

namespace Common
{
    public class HousekeeperViewModel : UserViewModel
    {
        public int UserId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int Id { get; set; }

        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual User User { get; set; } = null!;

    }
}