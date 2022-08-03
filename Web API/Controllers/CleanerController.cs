using App_Services.Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController:ControllerBase
    {
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
    }
}
