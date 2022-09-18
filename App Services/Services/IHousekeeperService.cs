using Common;

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
        HousekeeperViewModel GetById(int id);

        bool Delete(int permissionCode, int housekeeperId);
        void Create(HousekeeperViewModel housekeeper);
        void Update(int permissionCode, HousekeeperViewModel housekeeper);
    }
}
