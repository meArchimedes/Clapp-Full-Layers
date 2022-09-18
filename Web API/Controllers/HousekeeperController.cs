using App_Services.Services;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousekeeperController:BaseController
    {
       
        public readonly IMapper _mapper;
        IHousekeeperService service;
        public HousekeeperController(IHousekeeperService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<List<HousekeeperViewModel>> GetAll()
        {
            return service.GetList();
        }

        [HttpGet("GetById")]
        public ActionResult<HousekeeperViewModel> GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpDelete("deleteById")]
        public bool DeleteById(int AccessPermission, int id)
        {
            return service.Delete(AccessPermission, id);
        }

        [HttpPost("create")]
        public void Create(HousekeeperViewModel HousekeeperViewModel)
        {
            service.Create(HousekeeperViewModel);
        }

        [HttpPut("update")]
        public void Put(int PermissionCode, HousekeeperViewModel HousekeeperViewModel)
        {
            service.Update(PermissionCode, HousekeeperViewModel);
        }
    }
}
