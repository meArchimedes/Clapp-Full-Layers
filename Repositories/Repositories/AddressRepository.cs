using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task CreateAsync(Address address)
        {
            try
            {
                context.Addresses.Add(address);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int permissionCode, int id)
        {
            if (permissionCode == 1)
            {
                try
                {
                    context.Remove(context.Addresses.Where(a => a.AddressId == id));
                }
                catch
                {
                    return false;
                }
                return true;
            }
            else
            {
                throw new AccessViolationException();
            }
        }

        public bool DeleteAll(Address typeToDelete)
        {
           throw new Exception();
        }

        public List<Address> GetAll()
        {
            return context.Addresses.ToList();
        }

        public Address GetById(int id)
        {
            return (Address)context.Addresses.Where(c => c.AddressId == id);
        }

        public void Update(int userPermissionCode, Address objToUpdate)
        {
            if (userPermissionCode == 1)
            {
                try
                {
                    var a = context.Addresses.Where(a => a.AddressId == objToUpdate.AddressId).FirstOrDefault();
                    if (a != null)
                    {   
                        a.Country = objToUpdate.Country;
                        a.City = objToUpdate.City;
                        a.State = objToUpdate.State;
                        a.AddressLine1 = objToUpdate.AddressLine1;
                        a.AddressLine2 = objToUpdate.AddressLine2;
                        a.Zip = objToUpdate.Zip;
                        a.AddressId = objToUpdate.AddressId;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                Console.WriteLine("Access Permission needed for this action!");
                throw new AccessViolationException();
            }
        }
    }
}
