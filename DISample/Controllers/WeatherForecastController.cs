using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DISample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWheatherForecastService _wheatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWheatherForecastService wheatherForecastService)
        {
            _logger = logger;
            _wheatherForecastService = wheatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _wheatherForecastService.GetForecast();
        }
    }
}
