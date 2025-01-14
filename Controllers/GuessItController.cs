using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        readonly GuessItServices _guessItService;
        public GuessItController(GuessItServices guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("EasyMode")]
        public string EasyMode(string guess)
        {
            return _guessItService.EasyMode(guess);
        }

        [HttpGet]
        [Route("MediumMode")]
        public string MediumMode(string guess)
        {
            return _guessItService.MediumMode(guess);
        }

        [HttpGet]
        [Route("HardMode")]
        public string HardMode(string guess)
        {
            return _guessItService.HardMode(guess);
        }
    }
}