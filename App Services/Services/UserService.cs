using AutoMapper;
using Common;
using DAL_Repositories.Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public class UserService : IUserService
    {
        IUserRepository repo;
        IMapper mapper;
        public UserService(IUserRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void Create(User user)
        {
            repo.Create(user);
        }

        public bool Delete(User user)
        {
            return repo.Delete(user.Id);
        }

        public User GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<UserViewModel> GetList()
        {
            List<User> users = repo.GetAll();
            List<UserViewModel> UserVM = mapper.Map<List<UserViewModel>>(users);
            return UserVM;
        }

        public void Update(User user)
        {
            repo.Update(user);
        }
    }
}
