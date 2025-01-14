using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        readonly ReverseItAlphanumericServices _reverseItAlphanumericService;
        public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseItAlphanumericService)
        {
            _reverseItAlphanumericService = reverseItAlphanumericService;
        }

        [HttpPost]
        [Route("AddReverseItAlphanumeric/{input}")]
        public string AddReverseItAlphanumeric(string input)
        {
            _reverseItAlphanumericService.AddReverseItAlphanumeric(input);
            return _reverseItAlphanumericService.reverseItAlphanumeric;
        }
    }
}