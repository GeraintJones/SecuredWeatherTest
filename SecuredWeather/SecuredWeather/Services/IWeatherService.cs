using SecuredWeather.Services.Models;
using System.Threading.Tasks;

namespace SecuredWeather.Services
{
    public interface IWeatherService
    {
        Task<ForecastWeather> GetForecastByWoeId(int woeid);
    }
}