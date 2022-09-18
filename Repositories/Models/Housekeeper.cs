using System;
using System.Collections.Generic;

namespace DAL_Repositories.Models
{
    public partial class Housekeeper
    {
        public int Id { get; set; }

        public virtual User IdNavigation { get; set; } = null!;
    }
}
