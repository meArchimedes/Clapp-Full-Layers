using Common;
using AutoMapper;
using Repositories;

using System.Collections.Generic;
using DAL_Repositories.Models;

namespace App_Services.Services
{
    public class CleanerService : ICleanerService
    {
        ICleanerRepository repo;
        IMapper mapper;
        public CleanerService(ICleanerRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public List<CleanerViewModel> GetList()
        {
            List<Cleaner> cleaners = repo.GetAll();
            List<CleanerViewModel> CleanerVM = mapper.Map<List<CleanerViewModel>>(cleaners);
            return CleanerVM;
        }
        public CleanerViewModel GetById(int id)
        {
            Cleaner cleaner = repo.GetById(id);
            CleanerViewModel cleanerViewModel = mapper.Map<CleanerViewModel>(cleaner);
            return cleanerViewModel;
        }
        public bool Delete(int permissionCode, int cleanerId)
        {
            return repo.Delete(permissionCode, cleanerId);
        }
        public void Create(CleanerViewModel cleaner)
        {
            var cvm = mapper.Map<Cleaner>(cleaner);
            repo.CreateAsync(cvm);
        }
        public void Update(int userPermissionCode, CleanerViewModel cleaner)
        {
            var cvm = mapper.Map<Cleaner>(cleaner);
            repo.Update(userPermissionCode, cvm);
        }
    }
}