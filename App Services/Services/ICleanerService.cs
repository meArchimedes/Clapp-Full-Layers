using Common;
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public interface ICleanerService
    {
        List<CleanerViewModel> GetList();
        CleanerViewModel GetById(int id);

        bool Delete(int permissionCode, int cleanerId);
        void Create(CleanerViewModel cleaner);
        void Update(int permissionCode, CleanerViewModel cleaner);
    }
}
