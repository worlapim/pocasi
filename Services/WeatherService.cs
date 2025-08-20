using Newtonsoft.Json;
using Pocasi.Models;
using static Pocasi.Constants.Constants;

namespace Pocasi.Services
{
    public class WeatherService
    {
        public List<WeatherDisplayItem> GetWeather(Coord? coords)
        {
            if (coords == null)
            {
                return new List<WeatherDisplayItem>();
            }
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://api.openweathermap.org/data/2.5/forecast?lat={coords.Lat}&lon={coords.Lon}&appid={OPEN_WEATHER_API_KEY}&units=metric");

            var result = client.GetAsync(client.BaseAddress).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            Models.OpenWeatherApi.Root? root = JsonConvert.DeserializeObject<Models.OpenWeatherApi.Root>(json);
            return root?.List.Select(l => (WeatherDisplayItem)l).ToList() ?? new List<WeatherDisplayItem>();
        }
    }
}
