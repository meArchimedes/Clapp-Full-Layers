using DAL_Repositories.Models;
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

        public async Task CreateAsync(Cleaner cleaner)
        {
            try
            {
                context.Cleaners.Add(cleaner);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int permissionCode, int id)
        {
            if(permissionCode == 1)
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
            else
            {
                throw new AccessViolationException();
            }
            
        }

        public bool DeleteAll(Cleaner typeToDelete)
        {
            throw new NotImplementedException();
        }

        public List<Cleaner> GetAll()
        {
            return context.Cleaners.Include(c => c.IdNavigation).ToList();
        }

        public Cleaner GetById(int id)
        {
           
            return (Cleaner)context.Cleaners.Where(c => c.Id == id).Include(c => c.IdNavigation);
        }

        public void Update(int userPermissionCode, Cleaner objToUpdate)
        {
            if (userPermissionCode == 1)
            {
                try
                {
                    var c = context.Cleaners.Where(c => c.Id == objToUpdate.Id).FirstOrDefault();
                    if (c != null)
                    {
                        c.Perfectionism = objToUpdate.Perfectionism;
                        c.Efficiency = objToUpdate.Efficiency;
                        c.Price= objToUpdate.Price;
                        c.IdNavigation.FirstName= objToUpdate.IdNavigation.FirstName;
                        c.IdNavigation.LastName = objToUpdate.IdNavigation.LastName;
                        c.IdNavigation.Email= objToUpdate.IdNavigation.LastName;

                        c.Id = objToUpdate.Id;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                Console.WriteLine("Access Permission needed for this action!");
                throw new AccessViolationException();
            }
        }
    }
}
