using OpenWeatherMap.NetStandard.Abstractions;
using OpenWeatherMap.NetStandard.Models;
using Refit;
using System.Threading.Tasks;

namespace OpenWeatherMap.NetStandard
{
    /// <summary>
    /// Open Weather Map Client
    /// </summary>
    public class OpenWeatherMapClient
    {
        #region Fields

        private readonly IOpenWeatherMapApiContract _openWeatherMapApiService;
        private readonly string _apiKey;
        private const Unit DefaultUnit = Unit.Imperial;
        private const SearchAccuracy DefaultSearchAccuracy = SearchAccuracy.Like;
        private const ResponseType DefaultResponseType = ResponseType.JSON;

        #endregion

        #region Constructor

        public OpenWeatherMapClient(string apiKey)
        {
            _openWeatherMapApiService = RestService
                .For<IOpenWeatherMapApiContract>("http://api.openweathermap.org/data/2.5");
            _apiKey = apiKey;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get Weather By City Name
        /// </summary>
        /// <param name="cityName">City Name</param>
        /// <param name="countryCode">Country Code</param>
        /// <param name="unit">Unit. Default unit is imperial (Fahrenheit). To get temperature in celsius use Metric</param>
        /// <param name="searchAccuracy">Search Accuracy. Available options are like (close result) or accurate (accurate result)</param>
        /// <param name="responseType">Return response in JSON OR XML format. Default response type is JSON</param>
        /// <returns></returns>
        public async Task<WeatherApiResponse> GetWeatherByCityNameAsync(string cityName,
            string countryCode = null,
            Unit unit = DefaultUnit,
            SearchAccuracy searchAccuracy = DefaultSearchAccuracy,
            ResponseType responseType = DefaultResponseType)
        {
            if (string.IsNullOrWhiteSpace(countryCode))
                return await _openWeatherMapApiService
                    .GetWeatherByCityName(cityName: cityName,
                    unit: unit.ToString().ToLower(),
                    searchAccuracy: searchAccuracy.ToString().ToLower(),
                    responseType: responseType.ToString().ToLower(),
                    apiKey: _apiKey);

            return await _openWeatherMapApiService
                .GetWeatherByCityNameAndCountryCode(cityName: cityName,
                countryCode: countryCode,
                unit: unit.ToString().ToLower(),
                searchAccuracy: searchAccuracy.ToString().ToLower(),
                responseType: responseType.ToString().ToLower(),
                apiKey: _apiKey);
        }

        /// <summary>
        /// Get Weather By City Id
        /// </summary>
        /// <param name="cityId">City Id</param>
        /// <param name="unit">Unit</param>
        /// <param name="searchAccuracy">Search Accuracy. Available options are like (close result) or accurate (accurate result)</param>
        /// <param name="responseType">Return response in JSON OR XML format. Default response type is JSON</param>
        /// <returns></returns>
        public async Task<WeatherApiResponse> GetWeatherByCityIdAsync(string cityId,
            Unit unit = DefaultUnit,
            SearchAccuracy searchAccuracy = DefaultSearchAccuracy,
            ResponseType responseType = DefaultResponseType)
        {
            return await _openWeatherMapApiService
                .GetWeatherByCityId(cityId: cityId,
                unit: unit.ToString().ToLower(),
                searchAccuracy: searchAccuracy.ToString().ToLower(),
                responseType: responseType.ToString().ToLower(),
                apiKey: _apiKey);
        }

        /// <summary>
        /// Get Weather By Geographic Coordinates
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="unit">Unit</param>
        /// <param name="searchAccuracy">Search Accuracy. Available options are like (close result) or accurate (accurate result)</param>
        /// <param name="responseType">Return response in JSON OR XML format. Default response type is JSON</param>
        /// <returns></returns>
        public async Task<WeatherApiResponse> GetWeatherByGeographicCoordinatesAsync(string latitude, string longitude,
            Unit unit = DefaultUnit,
            SearchAccuracy searchAccuracy = DefaultSearchAccuracy,
            ResponseType responseType = DefaultResponseType)
        {
            return await _openWeatherMapApiService
                .GetWeatherByGeographicCoordinates(latitude: latitude,
                longitude: longitude,
                unit: unit.ToString().ToLower(),
                searchAccuracy: searchAccuracy.ToString().ToLower(),
                responseType: responseType.ToString().ToLower(),
                apiKey: _apiKey);
        }

        /// <summary>
        /// Get Weather By ZipCode
        /// </summary>
        /// <param name="zipCode">Zip Code</param>
        /// <param name="countryCode">Country Code</param>
        /// <param name="unit">Unit</param>
        /// <param name="searchAccuracy">Search Accuracy. Available options are like (close result) or accurate (accurate result)</param>
        /// <param name="responseType">Return response in JSON OR XML format. Default response type is JSON</param>
        /// <returns></returns>
        public async Task<WeatherApiResponse> GetWeatherByZipCodeAsync(string zipCode, string countryCode,
            Unit unit = DefaultUnit,
            SearchAccuracy searchAccuracy = DefaultSearchAccuracy,
            ResponseType responseType = DefaultResponseType)
        {
            return await _openWeatherMapApiService
                .GetWeatherByZipCode(zipCode: zipCode,
                countryCode: countryCode,
                unit: unit.ToString().ToLower(),
                searchAccuracy: searchAccuracy.ToString().ToLower(),
                responseType: responseType.ToString().ToLower(),
                apiKey: _apiKey);
        }

        #endregion
    }
}
