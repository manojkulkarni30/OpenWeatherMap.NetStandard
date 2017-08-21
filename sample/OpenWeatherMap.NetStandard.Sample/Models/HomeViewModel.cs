using OpenWeatherMap.NetStandard.Models;

namespace OpenWeatherMap.NetStandard.Sample.Models
{
    public class HomeViewModel
    {
        public string CityName { get; set; }

        public WeatherApiResponse WeatherApiResponse { get; set; }
    }
}
