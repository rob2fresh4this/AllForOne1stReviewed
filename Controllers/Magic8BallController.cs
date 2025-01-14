using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        readonly Magic8BallService _magic8BallService;
        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }
        [HttpGet]
        [Route("shakeBall/{question}")]
        public string GetResponse(string question)
        {
            return _magic8BallService.GetResponse(question);
        }
    }
}