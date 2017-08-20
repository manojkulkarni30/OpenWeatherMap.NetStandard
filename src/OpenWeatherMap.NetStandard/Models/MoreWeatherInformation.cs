using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    [JsonObject("weather")]
    public class MoreWeatherInformation
    {
        /// <summary>
        /// Weather condition id
        /// </summary>
        [JsonProperty("id")]
        public double WeatherConditionId { get; set; }

        /// <summary>
        /// Group of weather parameters (Rain, Snow, Extreme etc.)
        /// </summary>
        [JsonProperty("main")]
        public string Main { get; set; }

        /// <summary>
        /// Weather icon id
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Weather condition within the group
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonIgnore]
        public string DisplayIcon => $"http://openweathermap.org/img/w/{Icon}.png";

    }
}
