using AutoMapper;
using Common;
using DAL_Repositories.Models;
using Repositories;

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
            this.mapper = mapper;
        }
        public List<HousekeeperViewModel> GetList()
        {
            List<Housekeeper> housekeepers = repo.GetAll();
            List<HousekeeperViewModel> HousekeeperVM = mapper.Map<List<HousekeeperViewModel>>(housekeepers);
            return HousekeeperVM;
        }
        public HousekeeperViewModel GetById(int id)
        {
            Housekeeper housekeeper = repo.GetById(id);
            HousekeeperViewModel housekeeperViewModel = mapper.Map<HousekeeperViewModel>(housekeeper);
            return housekeeperViewModel;
        }
        public bool Delete(int permissionCode, int housekeeperId)
        {
            return repo.Delete(permissionCode, housekeeperId);
        }
        public void Create(HousekeeperViewModel housekeeper)
        {
            var hvm = mapper.Map<Housekeeper>(housekeeper);
            repo.CreateAsync(hvm);
        }
        public void Update(int userPermissionCode, HousekeeperViewModel housekeeper)
        {
            var hvm = mapper.Map<Housekeeper>(housekeeper);
            repo.Update(userPermissionCode, hvm);
        }
    }
}

