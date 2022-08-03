using Common;
using AutoMapper;
using Repositories;
using Repositories.Models;
using System.Collections.Generic;

namespace App_Services.Services
{
    //***
    public class CleanerService : ICleanerService
    {
        ICleanerRepository repo;
        IMapper mapper;
        public CleanerService(ICleanerRepository repo)
        {
            this.repo = repo;
            mapper = mapper;
        }
        public List<CleanerViewModel> GetList()
        {
            List<Cleaner> cleaners = repo.GetAll();
            List<CleanerViewModel> CleanerVM = mapper.Map<List<CleanerViewModel>>(cleaners);
            return CleanerVM;
        }
        public Cleaner GetById(int id)
        {
            return repo.GetById(id);
        }
        public bool Delete(Cleaner cleaner)
        {
            return repo.Delete(cleaner.Id);
        }
        public void Create(Cleaner cleaner)
        {
            repo.Create(cleaner);
        }
        void ICleanerService.Update(Cleaner cleaner)
        {
            repo.Update(cleaner);
        }
    }
}