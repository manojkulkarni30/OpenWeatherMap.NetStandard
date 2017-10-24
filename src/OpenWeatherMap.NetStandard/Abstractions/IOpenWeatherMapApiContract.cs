using OpenWeatherMap.NetStandard.Models;
using Refit;
using System.Threading.Tasks;

namespace OpenWeatherMap.NetStandard.Abstractions
{
    public interface IOpenWeatherMapApiContract
    {
        #region Current Weather API

        [Get("/weather?q={cityName}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<CurrentWeatherApiResponse> GetWeatherByCityNameAsync(string cityName, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?q={cityName},{countryCode}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<CurrentWeatherApiResponse> GetWeatherByCityNameAndCountryCodeAsync(string cityName, string countryCode, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?id={cityId}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<CurrentWeatherApiResponse> GetWeatherByCityIdAsync(string cityId, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?lat={latitude}&lon={longitude}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<CurrentWeatherApiResponse> GetWeatherByGeographicCoordinatesAsync(string latitude, string longitude, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/weather?zip={zipCode},{countryCode}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<CurrentWeatherApiResponse> GetWeatherByZipCodeAsync(string zipCode, string countryCode, string unit, string searchAccuracy, string responseType, string apiKey);

        #endregion

        #region Five Day Weather Forcast API

        [Get("/forecast?q={cityName}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<ForecastWeatherApiResponse> GetFiveDayWeatherForecastByCityNameAsync(string cityName, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/forecast?q={cityName},{countryCode}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<ForecastWeatherApiResponse> GetFiveDayWeatherForecastByCityNameAndCountryCodeAsync(string cityName, string countryCode, string unit, string searchAccuracy, string responseType, string apiKey);

        [Get("/forecast?id={cityId}&units={unit}&type={searchAccuracy}&mode={responseType}&appid={apiKey}")]
        Task<ForecastWeatherApiResponse> GetFiveDayWeatherForecastByCityIdAsync(string cityId, string unit, string searchAccuracy, string responseType, string apiKey);

        #endregion
    }
}
