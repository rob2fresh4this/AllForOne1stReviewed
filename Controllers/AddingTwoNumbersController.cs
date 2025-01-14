
using Microsoft.AspNetCore.Mvc;
using AllForOne.Service;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbers : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersService;

        public AddingTwoNumbers(AddingTwoNumbersServices addingTwoNumbersService)
        {
            _addingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpPost]
        [Route("addNumbers/{num1}/{num2}")]
        public string AddNumbers(string num1, string num2)
        {
            _addingTwoNumbersService.AddingTwoNumbers(num1, num2);
            return _addingTwoNumbersService.anwser;
        }
    }
}