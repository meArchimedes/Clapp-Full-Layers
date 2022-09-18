using DAL_Repositories.Models;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class HousekeeperViewModel : UserViewModel
    {
        public int Id { get; set; }

        public virtual User IdNavigation { get; set; } = null!;

    }
}