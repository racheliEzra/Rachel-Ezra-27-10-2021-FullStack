using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using System.Web.Http;


namespace weatherServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        [HttpGet("GetWeather/{locationKey}")]
        public async Task<ActionResult> getCurrentWeather(int locationKey)
        {
            try
            {
                var weather = await WeatherBLL.getCurrentWeather(locationKey);
                return Ok(weather);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
