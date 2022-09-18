using App_Services.Services;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:BaseController
    {
        public readonly IMapper _mapper;
        IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<List<UserViewModel>> GetAll()
        {
            return service.GetList();
        }

        [HttpGet("GetById")]
        public ActionResult<UserViewModel> GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpDelete("deleteById")]
        public bool DeleteById(int AccessPermission, int id)
        {
            return service.Delete(AccessPermission, id);
        }

        [HttpPost("create")]
        public void Create(UserViewModel userViewModel)
        {
            service.Create(userViewModel);
        }

        [HttpPut("update")]
        public void Put(int PermissionCode, UserViewModel userViewModel)
        {
            service.Update(PermissionCode, userViewModel);
        }
    }
}

