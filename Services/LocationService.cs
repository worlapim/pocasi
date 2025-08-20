using Newtonsoft.Json;
using Pocasi.Models;

namespace Pocasi.Services
{
    public class LocationService
    {
        public List<City>? GetAllCities()
        {
            using (StreamReader r = new StreamReader(".\\Data\\city.list.json"))
            {
                string json = r.ReadToEnd();
                List<City>? items = JsonConvert.DeserializeObject<List<City>>(json);
                return items;
            }
        }
    }
}
