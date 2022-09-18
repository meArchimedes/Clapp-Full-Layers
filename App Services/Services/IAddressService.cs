using Common;
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
        AddressViewModel GetById(int id);

        bool Delete(AddressViewModel address);
        bool DeleteAll(AddressViewModel address);
        void Create(AddressViewModel address);
        void Update(AddressViewModel address);
    }
}
