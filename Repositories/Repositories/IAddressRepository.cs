using DAL_Repositories.Models;
using Repositories;


namespace DAL_Repositories
{
    public interface IAddressRepository:IRepository<Address>
    {
        Task CreateAsync(Address address);
        void Create(Address objToCreate);
        bool Delete(int permissionCode, int id);
        bool DeleteAll(Address typeToDelete);
        List<Address> GetAll();
        Address GetById(int id);
        void Update(int userPermissionCode, Address objToUpdate);

    }
}
