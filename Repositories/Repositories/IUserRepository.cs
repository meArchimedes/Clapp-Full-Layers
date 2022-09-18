using DAL_Repositories.Models;
using Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Repositories.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        Task CreateAsync(User user);
        void Create(User objToCreate);
        bool Delete(int permissionCode, int id);
        bool DeleteAll(User typeToDelete);
        List<User> GetAll();
        User GetById(int id);
        void Update(int userPermissionCode, User objToUpdate);

    }
}
