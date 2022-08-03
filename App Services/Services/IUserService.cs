using Common;
using Repositories.Models;
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
        User GetById(int id);

        bool Delete(User user);
        void Create(User user);
        void Update(User user);
    }
}
