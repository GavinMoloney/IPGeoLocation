namespace GeoLocation.Models
{
    public class TimeZone
    {
        public string? Name { get; set; }
        public int Offset { get; set; }
        public string? CurrentTime { get; set; }
        public double CurrentTimeUnix { get; set; }
        public bool IsDst { get; set; }
        public int DstSavings { get; set; }
    }
}
