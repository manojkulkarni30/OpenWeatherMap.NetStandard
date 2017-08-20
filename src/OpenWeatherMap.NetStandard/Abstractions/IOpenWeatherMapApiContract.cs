using OpenWeatherMap.NetStandard.Models;
using Refit;
using System.Threading.Tasks;

namespace OpenWeatherMap.NetStandard.Abstractions
{
    public interface IOpenWeatherMapApiContract
    {
        [Get("/weather?q={cityName}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<WeatherApiResponse> GetWeatherByCityName(string cityName, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?q={cityName},{countryCode}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<WeatherApiResponse> GetWeatherByCityNameAndCountryCode(string cityName, string countryCode, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?id={cityId}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<WeatherApiResponse> GetWeatherByCityId(string cityId, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?lat={latitude}&lon={longitude}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<WeatherApiResponse> GetWeatherByGeographicCoordinates(string latitude, string longitude, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?zip={zipCode},{countryCode}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<WeatherApiResponse> GetWeatherByZipCode(string zipCode, string countryCode, string unit, string searchAccuracy, string responseType, string apiKey);
    }
}
