
using Microsoft.AspNetCore.Mvc;
using AllForOne.Service;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersService;

        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersService)
        {
            _addingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpGet]
        [Route("addNumbers/{num1}/{num2}")]
        public string AddNumbers(string num1, string num2)
        {
            _addingTwoNumbersService.AddingTwoNumbers(num1, num2);
            return _addingTwoNumbersService.anwser;
        }
    }
}