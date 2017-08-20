using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    public class WeatherApiResponse
    {
        /// <summary>
        /// Geolocation information of city
        /// </summary>
        [JsonProperty("coord")]
        public Geolocation Geolocation { get; set; }

        /// <summary>
        /// City Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Cloudiness in percentage
        /// </summary>
        [JsonProperty("clouds")]
        public Cloudiness Cloudiness { get; set; }

        /// <summary>
        /// Internal Parameters
        /// </summary>
        [JsonProperty("base")]
        public string Base { get; set; }

        /// <summary>
        /// Internal Parameter
        /// </summary>
        [JsonProperty("cod")]
        public double Cod { get; set; }

        /// <summary>
        /// City Id
        /// </summary>
        [JsonProperty("id")]
        public double CityId { get; set; }

        /// <summary>
        /// Time Of Data Calculation
        /// </summary>
        [JsonProperty("dt")]
        public double DataCalculationTime { get; set; }

        /// <summary>
        /// Weather Information
        /// </summary>
        [JsonProperty("main")]
        public Weather Weather { get; set; }

        /// <summary>
        /// Visibility
        /// </summary>
        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        /// <summary>
        /// Internal Parameters
        /// </summary>
        [JsonProperty("sys")]
        public InternalParameters InternalParameters { get; set; }

        /// <summary>
        /// More Weather Information
        /// </summary>
        [JsonProperty("weather")]
        public MoreWeatherInformation[] MoreWeatherInformation { get; set; }

        /// <summary>
        /// Wind
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
    }
}
