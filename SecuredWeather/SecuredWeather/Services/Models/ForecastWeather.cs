using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace SecuredWeather.Services.Models
{
    public class ForecastWeather
    {
        [JsonProperty("consolidated_weather")]
        public IEnumerable<DailyForecast> ConsolidatedWeather { get; set; }
        [JsonProperty("time")]
        public DateTime Time { get; set; }
        [JsonProperty("sun_rise")]
        public DateTime SunRise { get; set; }
        [JsonProperty("sun_set")]
        public DateTime SunSet { get; set; }
        [JsonProperty("timezone_name")]
        public string TimeZoneName { get; set; }

        [JsonProperty("parent")]
        public Location Parent { get; set; }

        [JsonProperty("sources")]
        public IEnumerable<Source> Sources { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("woeid")]
        public long WOEID { get; set; }
        [JsonProperty("latt_long")]
        public string LatLon { get; set; }
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }
}
