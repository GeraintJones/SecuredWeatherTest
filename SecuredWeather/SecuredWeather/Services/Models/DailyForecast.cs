using Newtonsoft.Json;
using System;
using System.Data.Common;

namespace SecuredWeather.Services.Models
{
    public class DailyForecast
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("weather_state_name")]
        public string WeatherStateName { get; set; }
        [JsonProperty("weather_state_abbr")]
        public string WeatherStateAbbreviation { get; set; }
        [JsonProperty("wind_direction_compass")]
        public string WindDirectionCompass { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("applicable_date")]
        public DateTime ApplicableDate { get; set; }
        [JsonProperty("min_temp")]
        public double MinTemp { get; set; }
        [JsonProperty("max_temp")]
        public double MaxTemp { get; set; }
        [JsonProperty("the_temp")]
        public double Temp { get; set; }
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }
        [JsonProperty("wind_direction")]
        public double WindDirection { get; set; }
        [JsonProperty("air_pressure")]
        public double AirPressure { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("visibility")]
        public double Visibility { get; set; }
        [JsonProperty("predictability")]
        public double Predictability { get; set; }
    }
}