using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QATask.DomainModels.DTOs;
using QATask.Services.Services.Contracts;
namespace QATask.API.Controllers
{

    [EnableCors("AllowCors"), Route("[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {

        private readonly IAnswerService _service;

        public AnswerController(IAnswerService service)
        {
            _service = service;
        }


        [HttpPost(Name = "Answer")]
        public bool GetAsync(AnswerDto answerDto )
        {
            return _service.GiveAnswer(answerDto);

        }
    }
    
}