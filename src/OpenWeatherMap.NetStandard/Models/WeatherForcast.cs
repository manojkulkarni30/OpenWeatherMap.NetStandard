using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    public class WeatherForcast
    {
        /// <summary>
        /// Weather Information
        /// </summary>
        [JsonProperty("main")]
        public Weather Weather { get; set; }

        /// <summary>
        /// Time of data forecasted
        /// </summary>
        [JsonProperty("dt")]
        public double WeatherForcastTime { get; set; }

        /// <summary>
        /// Cloudiness in percentage
        /// </summary>
        [JsonProperty("clouds")]
        public Cloudiness Cloudiness { get; set; }

        /// <summary>
        /// Date Time of calculation
        /// </summary>
        [JsonProperty("dt_txt")]
        public string DateTime { get; set; }

        /// <summary>
        /// Internal Parameters
        /// </summary>
        [JsonProperty("sys")]
        public InternalParameters InternalParameters { get; set; }

        /// <summary>
        /// Rain Information
        /// </summary>
        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// More Weather Information
        /// </summary>
        [JsonProperty("weather")]
        public MoreWeatherInformation[] MoreWeatherInformation { get; set; }

        /// <summary>
        /// Wind Information
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
    }
}