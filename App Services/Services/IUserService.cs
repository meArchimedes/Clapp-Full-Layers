using Common;
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public interface IUserService
    {
        List<UserViewModel> GetList();
        UserViewModel GetById(int id);

        bool Delete(int AccessPermission, int id);
        void Create(UserViewModel user);
        void Update(int AccessPermission, UserViewModel user);
    }
}
