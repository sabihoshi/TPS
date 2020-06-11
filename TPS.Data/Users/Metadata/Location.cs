namespace TPS.Data.Users
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Country { get; set; }

        public string? City { get; set; }

        public string? Street { get; set; }

        public string? Building { get; set; }

        public string? PostCode { get; set; }
    }
}