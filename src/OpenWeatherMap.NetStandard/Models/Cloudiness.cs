using Newtonsoft.Json;

namespace OpenWeatherMap.NetStandard.Models
{
    public class Cloudiness
    {
        [JsonProperty("all")]
        public double All { get; set; }
    }
}
