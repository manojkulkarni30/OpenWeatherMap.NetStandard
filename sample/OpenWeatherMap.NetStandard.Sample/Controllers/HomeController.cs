using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenWeatherMap.NetStandard.Models;
using OpenWeatherMap.NetStandard.Sample.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OpenWeatherMap.NetStandard.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string cityName="")
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.CityName = cityName;
            if(!string.IsNullOrWhiteSpace(homeViewModel.CityName))
            {
                var openWeatherMapApiKey = _configuration["OpenWeatherMapApiKey"];
                var openWeatherMapClient = new OpenWeatherMapClient(openWeatherMapApiKey);
                homeViewModel.WeatherApiResponse = await openWeatherMapClient
                    .GetWeatherByCityNameAsync(cityName,
                    unit:Unit.Metric);

                homeViewModel.FiveDayWeatherForecast = await openWeatherMapClient
                   .GetFiveDayWeatherForecastByCityNameAsync(cityName,
                   unit: Unit.Metric);
            }
            return View(homeViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
