using DAL_Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public ClappContext context;
        public UserRepository(ClappContext context)
        {
            this.context = context;
        }
        public void Create(User objToCreate)
        {
            context.Users.Add(objToCreate);
        }

        public async Task CreateAsync(User user)
        {
            try
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int permissionCode, int id)
        {
            if (permissionCode == 1)
            {
                try
                {
                    context.Remove(context.Users.Where(u => u.UserId == id));
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

        public bool DeleteAll(User typeToDelete)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
       
            return context.Users.Include(u=>u.AddressUsers).ToList();
        }

        public User GetById(int id)
        {
            
            return (User)context.Users.Where(u => u.UserId == id).Include(u => u.AddressUsers);
        }

        public void Update(int userPermissionCode, User objToUpdate)
        {
            if (userPermissionCode == 1)
            {
                try
                {
                    var u = context.Users.Where(u => u.UserId == objToUpdate.UserId).FirstOrDefault();
                    if (u != null)
                    {   
                        u.FirstName = objToUpdate.FirstName;
                        u.LastName = objToUpdate.LastName;
                        u.Status= objToUpdate.Status;
                        u.AddressUsers= objToUpdate.AddressUsers;
                        u.UserId = objToUpdate.UserId;
                        u.Email = objToUpdate.Email;
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
