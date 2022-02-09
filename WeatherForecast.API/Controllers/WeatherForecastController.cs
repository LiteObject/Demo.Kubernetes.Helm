using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.API.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            this._logger.LogInformation("\"{name}\" has been instantiated.", nameof(WeatherForecastController));
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            this._logger.LogInformation("\"{name}\" method has been invoked.", nameof(Get));

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            this._logger.LogDebug("Result from \"{method}\" method:\n {result}", nameof(Get), System.Text.Json.JsonSerializer.Serialize(result));

            return result;
        }
    }
}