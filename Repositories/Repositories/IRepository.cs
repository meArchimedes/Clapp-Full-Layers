using DAL_Repositories.Models;

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T objToCreate);
        Task CreateAsync(T objToCreate);
        void Update(int permissionCode, T objToUpdate);
        bool Delete(int permissionCode, int id);
        bool DeleteAll(T typeToDelete);
    }
}