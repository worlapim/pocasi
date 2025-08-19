namespace Pocasi.Models
{
    public class SearchViewModel
    {
        public string Location { get; set; } = "";
        public List<string>? Locations { get; set; } = [];
        public OpenWeatherApi.Root? Root { get; set; } = null;
    }
}
