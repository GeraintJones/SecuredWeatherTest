using Newtonsoft.Json;
using System;
using System.Data.Common;

namespace SecuredWeather.Models.Dtos
{
    public class DailyForecastDto
    {
        public long Id { get; set; }
     
        public string WeatherStateName { get; set; }
        
        public string WeatherStateAbbreviation { get; set; }
        public string WeatherStateImageUrl { get; set; }

        public string WindDirectionCompass { get; set; }
     
        public DateTime Created { get; set; }
     
        public string ApplicableDate { get; set; }
        
        public double MinTemp { get; set; }
        
        public double MaxTemp { get; set; }
      
        public double Temp { get; set; }
    
        public double WindSpeed { get; set; }
      
        public double WindDirection { get; set; }
      
        public double AirPressure { get; set; }
     
        public double Humidity { get; set; }
      
        public double Visibility { get; set; }
       
        public double Predictability { get; set; }
    }
}