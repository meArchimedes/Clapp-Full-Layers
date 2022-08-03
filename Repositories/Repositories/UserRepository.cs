using Repositories.Models;
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

        public bool Delete(int id)
        {
            try
            {
                context.Remove(context.Users.Where(u => u.Id == id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return (User)context.Users.Where(u => u.Id == id);
        }

        public void Update(User objToUpdate)
        {
            context.Remove(context.Users.Where(u => u.Id == objToUpdate.Id));
            context.Users.Add(objToUpdate);
        }
    }
}
