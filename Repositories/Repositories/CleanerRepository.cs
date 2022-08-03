using Repositories.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace DAL_Repositories.Repositories
{
    public class CleanerRepository : ICleanerRepository
    {
        public ClappContext context;
        public CleanerRepository(ClappContext context)
        {
            this.context = context;
        }
        public void Create(Cleaner objToCreate)
        {
            context.Cleaners.Add(objToCreate);
        }

        public bool Delete(int id)
        {
            try
            {
                context.Remove(context.Cleaners.Where(c => c.UserId == id));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Cleaner> GetAll()
        {
            return context.Cleaners.Include(c => c.Address).Include(c => c.BankDetails).ToList();
        }

        public Cleaner GetById(int id)
        {
            return (Cleaner)context.Cleaners.Where(c => c.Id == id);
        }

        public void Update(Cleaner objToUpdate)
        {
            context.Remove(context.Cleaners.Where(h => h.Id == objToUpdate.Id));
            context.Cleaners.Add(objToUpdate);
        }
    }
}
