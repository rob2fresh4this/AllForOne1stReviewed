using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib")]
        public string MadLib(string animal1, string container1, string leastFavColor, string bodyCovering, string verb1, string favoriteThing, string favoriteFood, string activityToDo, string changeAppearance, string favColor)
        {
            return _madLibServices.MadLib(animal1, container1, leastFavColor, bodyCovering, verb1, favoriteThing, favoriteFood, activityToDo, changeAppearance, favColor);
        }
    }
}