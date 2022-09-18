using DAL_Repositories.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICleanerRepository : IRepository<Cleaner>
    {
        Task CreateAsync(Cleaner cleaner);
        void Create(Cleaner objToCreate);
        bool Delete(int permissionCode, int id);
        bool DeleteAll(Cleaner typeToDelete);
        List<Cleaner> GetAll();
        Cleaner GetById(int id);
        void Update(int userPermissionCode, Cleaner objToUpdate);


    }
}
