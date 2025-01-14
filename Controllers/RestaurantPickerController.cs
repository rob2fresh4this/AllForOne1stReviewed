
using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        readonly RestaurantPickerService _restaurantPickerService;
        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("pickRestaurant/{categoryMexicanChineseJapanese}")]
        public string GetResponse(string categoryMexicanChineseJapanese)
        {
            return _restaurantPickerService.PickedRestaurant(categoryMexicanChineseJapanese);
        }
    }
}