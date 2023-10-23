using Bindicate.Project.Services;
using Bindicate.ProjectWithOptions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bindicate.Host.Controllers
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
        private readonly IAddNumberService _addNumberService;
        private readonly ICreateStringService _createStringService;
        private readonly IServiceWithOptions _serviceWithOptions;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IAddNumberService addNumberService,
            ICreateStringService createStringService,
            IServiceWithOptions serviceWithOptions)
        {
            _logger = logger;
            _addNumberService = addNumberService;
            _createStringService = createStringService;
            _serviceWithOptions = serviceWithOptions;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            int result = _addNumberService.AddNumber(5, 5); // = 10
            var stringResult = _createStringService.CombineStrings("this", "that"); // = "this-that"
            var resultFromServiceWithOptions = _serviceWithOptions.CombineOptions(stringResult); // = "this-that_test_9"

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}