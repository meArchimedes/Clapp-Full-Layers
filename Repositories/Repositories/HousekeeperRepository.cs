using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Address = Repositories.Models.Address;

namespace Repositories
{
    public class HousekeeperRepository : IHousekeeperRepository
    {
        ClappContext context;
        public HousekeeperRepository(ClappContext context)
        {
            this.context = context;
        }
        public void Create(Housekeeper objToCreate)
        {
            context.Housekeepers.Add(objToCreate);
        }

        public bool Delete(int id)
        {
            try
            {
                context.Remove(context.Housekeepers.Where(h => h.UserId == id));
            }
            catch
            {
                throw new Exception();
                return false;
            }
            return true;
        }

        public List<Housekeeper> GetAll()
        {
            
            return context.Housekeepers.Include(h => h.PaymentMethod).Include(h => h.Address).ToList();
        }

        public Housekeeper GetById(int id)
        {
            return context.Housekeepers.Where(h => h.Id == id).Include(h => h.Address).Include(h => h.PaymentMethod).FirstOrDefault();
        }

        public void Update(Housekeeper objToUpdate)
        {
            context.Remove(context.Housekeepers.Where(h => h.Id == objToUpdate.Id));
            context.Housekeepers.Add(objToUpdate);
        }
    }
}
