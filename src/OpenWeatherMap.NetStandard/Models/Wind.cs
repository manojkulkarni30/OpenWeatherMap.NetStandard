using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    public class Wind
    {
        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonProperty("deg")]
        public double WindDirection { get; set; }

        /// <summary>
        /// Wind speed
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}