using AutoMapper;
using Common;
using DAL_Repositories;
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public class AddressService : IAddressService
    {
        public static int AccessPermission = 0;
        IMapper mapper;
        IAddressRepository repo;
        public AddressService(IAddressRepository repo,IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        public void Create(AddressViewModel address)
        {
            var a = mapper.Map<Address>(address);
            repo.Create(a);
        }

        public bool Delete(AddressViewModel address)
        {
            return repo.Delete(AccessPermission, address.AddressId);
        }
        public bool DeleteAll(AddressViewModel address)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel GetById(int id)
        {
            var addressVM = repo.GetById(id);
            return mapper.Map<AddressViewModel>(addressVM);
        }

        public List<AddressViewModel> GetList()
        {
            List<Address> addresses = repo.GetAll();
            List<AddressViewModel> adressesVM = mapper.Map<List<AddressViewModel>>(addresses);
            return adressesVM;

        }

        public void Update(AddressViewModel address)
        {
            var a = mapper.Map<Address>(address);
            repo.Update(AccessPermission, a);
        }
    }
}
