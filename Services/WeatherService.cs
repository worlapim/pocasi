using Newtonsoft.Json;
using Pocasi.Models;
using System.Threading.Tasks;

namespace Pocasi.Services
{
    public class WeatherService
    {
        public Models.OpenWeatherApi.Root? GetWeather(Coord coords) 
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://api.openweathermap.org/data/2.5/forecast?lat={coords.Lat}&lon={coords.Lon}&appid=497f48672e04b95158b19e7f116e8fc3&units=metric");

            var result = client.GetAsync(client.BaseAddress).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            Models.OpenWeatherApi.Root? root = JsonConvert.DeserializeObject<Models.OpenWeatherApi.Root>(json);
            return root;
        }
    }
}
