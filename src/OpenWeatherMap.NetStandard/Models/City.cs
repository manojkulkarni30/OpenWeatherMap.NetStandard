using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    /// <summary>
    /// City Information
    /// </summary>
    public class City
    {
        /// <summary>
        /// City Id
        /// </summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Geolocation information of city
        /// </summary>
        [JsonProperty("coord")]
        public Geolocation Geolocation { get; set; }

        /// <summary>
        /// Country Code
        /// </summary>
        [JsonProperty("country")]
        public string CountryCode { get; set; }
    }
}
