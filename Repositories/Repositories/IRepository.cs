using Repositories.Models;

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T objToCreate);
        void Update(T objToUpdate);
        bool Delete(int id);
    }
}