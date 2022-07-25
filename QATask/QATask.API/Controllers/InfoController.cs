using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QATask.API.Controllers;
using QATask.DomainModels.DTOs;
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
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _service.GetInfo());

        }
    }
    
}