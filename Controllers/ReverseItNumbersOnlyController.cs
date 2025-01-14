using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        readonly ReverseItNumberOnlyServices _reverseItNumbersOnlyService;
        public ReverseItNumbersOnlyController(ReverseItNumberOnlyServices reverseItNumbersOnlyService)
        {
            _reverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }

        [HttpPost]
        [Route("AddReverseItNumbersOnly/{input1}")]
        public string AddReverseItNumbersOnly(string input1)
        {
            _reverseItNumbersOnlyService.AddReverseItNumberOnly(input1);
            return _reverseItNumbersOnlyService.reverseItNumberOnly;
    }
}
}