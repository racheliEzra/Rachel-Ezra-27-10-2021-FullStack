using BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        [HttpGet("GetPlacesBySearch/{searchWord}")]
        public async Task<ActionResult> GetPlacesBySearch(string searchWord)
        {
            try
            {
                var places = await Task.Run(() => (PlacesBLL.GetPlacesBySearch(searchWord)));
                return Ok(places);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
