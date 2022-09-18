using App_Services.Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using DAL_Repositories.Models;

namespace Web_API.Controllers
{
    public abstract class AddressController<T>:ControllerBase
    {
        AddressService addressService;
        public AddressController(AddressService addressService)
        {
            this.addressService = addressService;
        }
        [HttpGet("~/Clapp/{T}'s/GetAllAddresses")]
        public virtual ActionResult<List<AddressViewModel>> GetAll()
        {
            var result = addressService.GetList();
            if (result.Count == 0)
                return NoContent();
            //foreach (var address in result)
            //{
            //    if (address.User is not T)
            //        result.Remove(address);
            //}
            return result;
        }
        [HttpGet("~/Clapp/{T}'s/GetAddressById")]
        public virtual ActionResult<AddressViewModel> GetById(int id)
        {
            var result = addressService.GetById(id);
            if (result == null||result is not T)
                return NoContent();
            return result;
        }
        [HttpDelete("~/Clapp/{T}/DeleteById")]
        public virtual bool DeleteById(AddressViewModel addressVM)//***
        {
            try
            {
                addressService.Delete(addressVM);
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete("~/Clapp/{T}/DeleteAllAddresses")]
        private bool DeleteAll(AddressViewModel address)
        {
            try
            {
                addressService.DeleteAll(address);
                return true;
            }
            catch { return false; }
        }
        [HttpPost("~/Clapp/{T}/CreateAddress")]
        public bool Post(AddressViewModel address)
        {
            try
            {
                addressService.Create(address);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
