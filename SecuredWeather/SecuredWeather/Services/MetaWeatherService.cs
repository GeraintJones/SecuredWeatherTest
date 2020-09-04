using SecuredWeather.Services.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace SecuredWeather.Services
{
    public class MetaWeatherService : IWeatherService
    {
        private HttpClient _httpClient;
        private ILogger<MetaWeatherService> _logger;
        private IConfiguration _configuration;

        public MetaWeatherService(HttpClient httpClient, IConfiguration configuration, ILogger<MetaWeatherService> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
        }
        public async Task<ForecastWeather> GetForecastByWoeId(int woeid)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_configuration["ExternalResource:baseUrl"]}{_configuration["ExternalResource:location"]}{woeid}");

                response.EnsureSuccessStatusCode();

                var forecastText = await response.Content.ReadAsStringAsync();
                var forecast = JsonConvert.DeserializeObject<ForecastWeather>(forecastText);
                return forecast;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Exception while retrieving forecast: {ex.Message}");
                throw ex;
            }
        }
    }
}
