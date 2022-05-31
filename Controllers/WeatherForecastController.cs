using Microsoft.AspNetCore.Mvc;

namespace dotnetcore5withhangfire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController()
        {
        }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            
        }

        /// <summary>Gets the summary.</summary>
        /// <param name="a">a.</param>
        /// <returns>The summary for the given index.</returns>
        [HttpGet(Name = "GetWeatherForecast-Summary")]
        public string GetSummary(int a)
        {
            if (a > 0 && a < Summaries.Length)
            {
                return Summaries.GetValue(a).ToString();
            }
            return string.Empty;
        }
    }
}