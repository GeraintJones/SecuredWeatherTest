using System.Collections.Generic;

namespace SecuredWeather.Models.Dtos
{
    public class ForecastWeatherDto
    {
        public IEnumerable<DailyForecastDto> ConsolidatedWeather { get; set; }
      
        public string RetrievedAt { get; set; }
     
        public string Title { get; set; }
    }
}
