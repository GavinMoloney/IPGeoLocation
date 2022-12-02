namespace GeoLocation.Models
{
    public class TimeZone  //renamed to match json formats
    {
        public string? name { get; set; }
        public int offset { get; set; }
        public string? current_time { get; set; }
        public double current_time_unix { get; set; }
        public bool is_dst { get; set; }
        public int dst_savings { get; set; }
    }
}
