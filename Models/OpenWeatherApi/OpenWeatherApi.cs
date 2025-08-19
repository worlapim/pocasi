using Newtonsoft.Json;

namespace Pocasi.Models.OpenWeatherApi
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public Coord Coord { get; set; } = new Coord();
        public string Country { get; set; } = "";
        public int Population { get; set; }
        public int Timezone { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Coord
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
    }

    public class List
    {
        public int Dt { get; set; }
        public Main Main { get; set; } = new Main();
        public List<Weather> Weather { get; set; } = new List<Weather>();
        public Clouds Clouds { get; set; } = new Clouds();
        public Wind Wind { get; set; } = new Wind();
        public int Visibility { get; set; }
        public double Pop { get; set; }
        public Sys Sys { get; set; } = new Sys();
        [JsonProperty("dt_txt")]
        public string DtTxt { get; set; } = "";
        public Rain Rain { get; set; } = new Rain();
    }

    public class Main
    {
        public double Temp { get; set; }
        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }
        [JsonProperty("grnd_level")]
        public int GrndLevel { get; set; }
        public int Humidity { get; set; }
        [JsonProperty("temp_kf")]
        public double TempKf { get; set; }
    }

    public class Rain
    {
        [JsonProperty("3h")]
        public double ThreeH { get; set; }
    }

    public class Root
    {
        public string Cod { get; set; } = "";
        public int Message { get; set; }
        public int Cnt { get; set; }
        public List<List> List { get; set; } = new List<List>();
        public City City { get; set; } = new City();
    }

    public class Sys
    {
        public string Pod { get; set; } = "";
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; } = "";
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "";
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }
}
