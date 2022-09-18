using AutoMapper;
using Common;
using DAL_Repositories.Repositories;
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public class UserService : IUserService
    {
        public static int AccessPermission = 0;
        IUserRepository repo;
        IMapper mapper;
        public UserService(IUserRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public List<UserViewModel> GetList()
        {
            List<User> users = repo.GetAll();
            List<UserViewModel> UserVM = mapper.Map<List<UserViewModel>>(users);
            return UserVM;
        }
        public UserViewModel GetById(int id)
        {
            User user = repo.GetById(id);
            UserViewModel userViewModel = mapper.Map<UserViewModel>(user);
            return userViewModel;
        }
        public bool Delete(int permissionCode, int userId)
        {
            return repo.Delete(permissionCode, userId);
        }
        public void Create(UserViewModel user)
        {
            var uvm = mapper.Map<User>(user);
            repo.CreateAsync(uvm);
        }
        public void Update(int userPermissionCode, UserViewModel user)
        {
            var uvm = mapper.Map<User>(user);
            repo.Update(userPermissionCode, uvm);
        }
    }
}
