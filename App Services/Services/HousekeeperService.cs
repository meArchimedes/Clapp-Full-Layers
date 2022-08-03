using AutoMapper;
using Common;
using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Services
{
    public class HousekeeperService : IHousekeeperService
    {
        //***
        IHousekeeperRepository repo;
        IMapper mapper;
        public HousekeeperService(IHousekeeperRepository repo, IMapper mapper)
        {
            this.repo = repo;
            mapper = mapper;
        }
        public List<HousekeeperViewModel> GetList()
        {
            List<Housekeeper> hks = repo.GetAll();
            List<HousekeeperViewModel> HVM = mapper.Map<List<HousekeeperViewModel>>(hks);
            return HVM;
        }
        public Housekeeper GetById(int id)
        {
            return repo.GetById(id);
        }
        public bool Delete(Housekeeper housekeeper)
        {
            return repo.Delete(housekeeper.Id);
        }
        public void Create(Housekeeper housekeeper)
        {
            repo.Create(housekeeper);
        }
        public void Update(Housekeeper housekeeper)
        {
            repo.Update(housekeeper);
        }
    }
}
