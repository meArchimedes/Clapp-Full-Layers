using Common;
using Repositories.Models;
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
        Cleaner GetById(int id);

        bool Delete(Cleaner cleaner);
        void Create(Cleaner cleaner);
        void Update(Cleaner cleaner);
    }
}
