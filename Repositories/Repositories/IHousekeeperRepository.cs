using DAL_Repositories.Models;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IHousekeeperRepository : IRepository<Housekeeper>
    {
        Task CreateAsync(Housekeeper housekeeper);
        void Create(Housekeeper objToCreate);
        bool Delete(int permissionCode, int id);
        bool DeleteAll(Housekeeper typeToDelete);
        List<Housekeeper> GetAll();
        Housekeeper GetById(int id);
        void Update(int userPermissionCode, Housekeeper objToUpdate);

    }
}
