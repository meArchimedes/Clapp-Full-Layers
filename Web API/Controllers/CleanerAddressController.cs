using App_Services.Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using DAL_Repositories.Models;

namespace Web_API.Controllers
{
    public class CleanerAddressController : AddressController<Cleaner>
    {
        IAddressService addressService;

        public CleanerAddressController(AddressService addressService) : base(addressService)
        {
        }
    }
}
