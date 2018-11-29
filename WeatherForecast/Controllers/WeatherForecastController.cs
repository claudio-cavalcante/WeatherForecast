using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Data;
using WeatherForecast.Models;
using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastItemDbContext _context;

        public WeatherForecastController(WeatherForecastItemDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecastItem>> Get()
        {
            var rng = new Random();
            var number = Math.Round((decimal)rng.Next(0, 100), 0);

            if (number % 2 == 0)
            {
                var weatherForecastItemList = _context.WeatherForecastItem.ToList();

                return Ok(weatherForecastItemList); 
            }

            return StatusCode(500);
        }       
    }
}
