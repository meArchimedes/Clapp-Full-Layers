using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public interface IHousekeeperService
    {
        List<HousekeeperViewModel> GetList();
        Housekeeper GetById(int id);

        bool Delete(Housekeeper housekeeper);
        void Create(Housekeeper housekeeper);
        void Update(Housekeeper housekeeper);
    }
}
