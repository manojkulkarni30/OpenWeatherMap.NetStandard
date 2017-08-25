using Newtonsoft.Json;
namespace OpenWeatherMap.NetStandard.Models
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double RainVolumeForLastThreeHours { get; set; }
    }
}
