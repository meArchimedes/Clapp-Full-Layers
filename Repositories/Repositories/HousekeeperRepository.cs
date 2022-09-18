using DAL_Repositories.Models;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories
{
    public class HousekeeperRepository : IHousekeeperRepository
    {
        public static int AccessPermission = 0;
        public ClappContext context;
        public HousekeeperRepository(ClappContext context)
        {
            this.context = context;
        }

        public void Create(Housekeeper objToCreate)
        {
            context.Housekeepers.Add(objToCreate);
        }
        public async Task CreateAsync(Housekeeper housekeeper)
        {
            try
            {
                context.Housekeepers.Add(housekeeper);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int permissionCode, int id)
        {
            if (permissionCode ==1)
            {
                try
                {
                    context.Remove(context.Housekeepers.Where(a => a.Id == id));
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

        public bool DeleteAll(Housekeeper typeToDelete)
        {
            throw new Exception();
        }

        public List<Housekeeper> GetAll()
        {
            return context.Housekeepers.Include(h=>h.IdNavigation).ToList();
        }

        public Housekeeper GetById(int id)
        {
              return (Housekeeper)context.Housekeepers.Include(h => h.IdNavigation).Where(c => c.Id == id);
        }

        public void Update(int userPermissionCode, Housekeeper objToUpdate)
        {
            if (userPermissionCode == 1)
            {
                try
                {
                    var h = context.Housekeepers.Where(h => h.Id == objToUpdate.Id).FirstOrDefault();
                    
                   
                    h.IdNavigation.FirstName = objToUpdate.IdNavigation.FirstName;
                    h.IdNavigation.LastName = objToUpdate.IdNavigation.LastName;
                    h.IdNavigation.Email = objToUpdate.IdNavigation.LastName;
                    h.IdNavigation.Status= objToUpdate.IdNavigation.Status;
                    //h.Id = h.IdNavigation.id;
                    h.IdNavigation = null;

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

