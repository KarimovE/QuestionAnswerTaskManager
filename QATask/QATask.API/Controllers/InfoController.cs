using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QATask.Services.Services.Contracts;
namespace QATask.API.Controllers
{

    [EnableCors("AllowCors"), Route("[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {

        private readonly IInfoService _service;

        public InfoController(IInfoService service)
        {
            _service = service;
        }


        [HttpGet(Name = "Info")]
        public IActionResult GetAsync()
        {
            return Ok(_service.GetInfo());

        }
    }
    
}