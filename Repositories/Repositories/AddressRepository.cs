using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Models;

namespace DAL_Repositories.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public ClappContext context;
        public AddressRepository(ClappContext context)
        {
            this.context = context;
        }

        public void Create(Address objToCreate)
        {
            context.Addresses.Add(objToCreate);
        }

        public bool Delete(int id)
        {
            try
            {
                context.Remove(context.Addresses.Where(a => a.AddressId == id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Address> GetAll()
        {
            return context.Addresses.ToList();
        }

        public Address GetById(int id)
        {
            return (Address)context.Addresses.Where(c => c.AddressId == id);
        }

        public void Update(Address objToUpdate)
        {
            context.Remove(context.Addresses.Where(h => h.AddressId == objToUpdate.AddressId));
            context.Addresses.Add(objToUpdate);
        }
    }
}
