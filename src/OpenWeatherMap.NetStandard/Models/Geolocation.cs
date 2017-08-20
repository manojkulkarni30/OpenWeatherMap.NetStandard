using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    /// <summary>
    /// Geolocation Information
    /// </summary>
    public class Geolocation
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }

}