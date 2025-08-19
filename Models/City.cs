namespace Pocasi.Models
{
    public class City
    {
        public decimal Id { get; set; }
        public string Name { get; set; } = "";
        public string State { get; set; } = "";
        public string Country { get; set; } = "";
        public Coord Coord { get; set; } = new Coord();

    }
}
