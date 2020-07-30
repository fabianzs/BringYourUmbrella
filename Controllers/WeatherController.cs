using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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