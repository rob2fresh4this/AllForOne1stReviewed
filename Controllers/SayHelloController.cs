using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloService _sayHelloService;

        public SayHelloController(SayHelloService sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }

        [HttpPost]
        [Route("SayHelloTo")]
        public string SayHelloTo(string name)
        {
            return _sayHelloService.SayHelloTo(name);
        }

    }
}