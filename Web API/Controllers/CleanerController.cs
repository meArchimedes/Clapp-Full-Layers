using App_Services.Services;
using AutoMapper;
using Common;
using DAL_Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController:ControllerBase
    {
        public readonly IMapper _mapper;
        ICleanerService service;
        public CleanerController(ICleanerService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<List<CleanerViewModel>> GetAll()
        {
            return service.GetList();
        }

        [HttpGet("GetById")]
        public ActionResult<CleanerViewModel> GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpDelete("deleteById")]
        public bool DeleteById(int AccessPermission, int id)
        {
            return service.Delete(AccessPermission, id);
        }

        [HttpPost("create")]
        public void Create(CleanerViewModel cleanerViewModel)
        {
            service.Create(cleanerViewModel);
        }

        [HttpPut("update")]
        public void Put(int PermissionCode, CleanerViewModel cleanerViewModel)
        {
            service.Update(PermissionCode, cleanerViewModel);
        }
    }
}
