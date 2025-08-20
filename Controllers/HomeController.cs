using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pocasi.Models;
using Pocasi.Services;

namespace pocasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LocationService _locationService;
        private readonly WeatherService _weatherService;

        public HomeController(ILogger<HomeController> logger, LocationService locationService, WeatherService weatherService)
        {
            _logger = logger;
            _locationService = locationService;
            _weatherService = weatherService;
        }

        public IActionResult Index(string search)
        {
            var locations = _locationService.GetAllCities();
            var searchedLocation = locations?.FirstOrDefault(c => c.Name == search);
            SearchViewModel searchViewModel = new SearchViewModel 
            { 
                Location = search,
                Locations = locations?.Select(c => c.Name).Distinct().ToList(),
                WeatherDisplayItems = _weatherService.GetWeather(searchedLocation?.Coord),
            };
            return View(searchViewModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
