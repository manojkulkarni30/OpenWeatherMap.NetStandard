using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    [JsonObject("sys")]
    public class InternalParameters
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("type")]
        public double Type { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        /// <summary>
        /// Country code (GB, JP etc.)
        /// </summary>
        [JsonProperty("country")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Sunrise time, unix, UTC
        /// </summary>
        [JsonProperty("sunrise")]
        public double SunriseTime { get; set; }

        /// <summary>
        /// Sunset time, unix, UTC
        /// </summary>
        [JsonProperty("sunset")]
        public double SunsetTime { get; set; }


    }

}