using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    public class ForecastWeatherApiResponse
    {
        /// <summary>
        /// Number of lines returned by this API call
        /// </summary>
        [JsonProperty("cnt")]
        public double Count { get; set; }

        /// <summary>
        /// Weather Forcast Information
        /// </summary>
        [JsonProperty("list")]
        public WeatherForcast[] List { get; set; }

        /// <summary>
        /// City Information
        /// </summary>
        [JsonProperty("city")]
        public City City { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("cod")]
        public string Code { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("message")]
        public double Message { get; set; }
    }
}
