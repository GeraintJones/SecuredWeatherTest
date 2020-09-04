using SecuredWeather.Models.Dtos;
using SecuredWeather.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace SecuredWeather.Models
{
    public static class Mappers
    {
        public static ForecastWeatherDto ToDto(this ForecastWeather source, string imageUrlTemplate, string type)
        {
            return new ForecastWeatherDto
            {
                ConsolidatedWeather = source.ConsolidatedWeather.ToDtos(imageUrlTemplate, type),
                RetrievedAt = $"{source.Time.ToLongTimeString()} on {source.Time.ToShortDateString()}",
                Title = source.Title,
            };
        }

        public static IEnumerable<DailyForecastDto> ToDtos(this IEnumerable<DailyForecast> source, string imageUrlTemplate, string type)
        {
            return source.Select(i => i.ToDto(imageUrlTemplate, type)).ToList();
        }

        public static DailyForecastDto ToDto(this DailyForecast source, string imageUrlTemplate, string type)
        {
            return new DailyForecastDto
            {
                ApplicableDate = source.ApplicableDate.ToShortDateString(),
                Created = source.Created,
                WeatherStateAbbreviation = source.WeatherStateAbbreviation,
                WeatherStateName = source.WeatherStateName,
                WeatherStateImageUrl = $"{imageUrlTemplate}{source.WeatherStateAbbreviation}.{type}"
            };
        }
    }
}
