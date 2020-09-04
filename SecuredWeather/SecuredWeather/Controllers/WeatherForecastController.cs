using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SecuredWeather.Models;
using SecuredWeather.Models.Dtos;
using SecuredWeather.Services;

namespace SecuredWeather.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;
        private readonly IConfiguration _configuration;

        public WeatherForecastController(IWeatherService weatherService, IConfiguration configuration, ILogger<WeatherForecastController> logger)
        {
            _weatherService = weatherService;
            _configuration = configuration;
            _logger = logger;
        }

        [HttpGet("{woeid}")]
        public async Task<ForecastWeatherDto> Get(int woeid)
        {
            try
            {
                var forecast = await _weatherService.GetForecastByWoeId(woeid);
                return forecast.ToDto($"{_configuration["ExternalResource:baseUrl"]}{_configuration["ExternalResource:images"]}", _configuration["ExternalResource:type"]);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Weather forecast exception: {ex.Message}");
            }
            return null;
        }

    }
}
