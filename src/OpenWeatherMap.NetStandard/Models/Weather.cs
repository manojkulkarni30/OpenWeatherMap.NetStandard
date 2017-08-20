using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    /// <summary>
    /// Weather Information
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// Temperature
        /// </summary>
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Humidity in percentage
        /// </summary>
        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        /// <summary>
        /// Minimum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally)
        /// </summary>
        [JsonProperty("temp_min")]
        public double MinimumTemperature { get; set; }

        /// <summary>
        /// Maximum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally)
        /// </summary>
        [JsonProperty("temp_max")]
        public double MaximumTemperature { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public double SeaLevelPressure { get; set; }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public double GroundLevelPressure { get; set; }
    }
}