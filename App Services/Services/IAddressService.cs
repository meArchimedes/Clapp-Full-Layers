using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public interface IAddressService
    {
        List<AddressViewModel> GetList();
        Address GetById(int id);

        bool Delete(Address address);
        void Create(Address address);
        void Update(Address address);
    }
}
