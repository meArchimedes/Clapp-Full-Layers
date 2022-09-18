using App_Services.Services;
using DAL_Repositories.Models;

namespace Web_API.Controllers
{
    public class HousekeeperAddressController : AddressController<Housekeeper>
    {
        IAddressService addressService;

        public HousekeeperAddressController(AddressService addressService) : base(addressService)
        {
        }
        
    }
}
