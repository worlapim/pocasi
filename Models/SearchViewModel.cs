namespace Pocasi.Models
{
    public class SearchViewModel
    {
        public string Location { get; set; } = "";
        public List<string>? Locations { get; set; } = [];
        public List<WeatherDisplayItem> WeatherDisplayItems { get; set; } = new List<WeatherDisplayItem>();
    }
}
