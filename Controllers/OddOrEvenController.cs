using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        readonly OddOrEvenServices _oddOrEvenService;
        public OddOrEvenController(OddOrEvenServices oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }

        [HttpPost]
        [Route("AddOddOrEven/{number}")]
        public string AddOddOrEven(string number)
        {
            _oddOrEvenService.AddOddOrEven(number);
            return _oddOrEvenService.oddOrEven;
        }
    }
}