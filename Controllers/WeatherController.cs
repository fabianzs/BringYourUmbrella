using Microsoft.AspNetCore.Mvc;

namespace BringYourUmbrella.Controllers
{
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        [Route("weather")]
        public IActionResult Get()
        {
            return Ok("nyuszó");
        }
    }
}