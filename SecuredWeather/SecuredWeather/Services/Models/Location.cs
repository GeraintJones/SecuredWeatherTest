using Newtonsoft.Json;

namespace SecuredWeather.Services.Models
{
    public class Location
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("woeid")]
        public long WOEID { get; set; }
        [JsonProperty("latt_long")]
        public string LatLon { get; set; }
    }
}