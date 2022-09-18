using App_Services.Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using DAL_Repositories.Models;

namespace Web_API.Controllers
{
    public class UserAddressController: AddressController<User>
    {
        AddressService addressService;

        public UserAddressController(AddressService addressService) : base(addressService)
        {
        }
        
    }
}
