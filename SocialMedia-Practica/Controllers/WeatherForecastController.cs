using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practica.Data;

namespace Practica.Controllers
{
    [ApiController]
    [Route("[controller]")]
       public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly SocialMediaDb _db;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SocialMediaDb db)
        {
            _logger = logger;
            _db = db;
        }

        
        [HttpGet("PreziVremeaCumetre")]
        public IEnumerable<WeatherForecast> Get(int numberOfDaysToPredict)
        {
                  
            var toReturn = Enumerable.Range(1, numberOfDaysToPredict).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return toReturn; 
        }
    }
}