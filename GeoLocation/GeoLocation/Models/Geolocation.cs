namespace GeoLocation.Models
{
    public class Geolocation
    {
        public string? Ip { get; set; }
        public string? Hostname { get; set; }
        public string? ContinentCode { get; set; }
        public string? ContinentName { get; set; }
        public string? CountryCode2 { get; set; }
        public string? CountryCode3 { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCapital { get; set; }
        public string? StateProvince { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Zipcode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Is_eu { get; set; }
        public string? CallingCode { get; set; }
        public string? CountryTld { get; set; }
        public string? Languages { get; set; }
        public string CountryFlag { get; set; }
        public string? Isp { get; set; }
        public string? ConnectionType { get; set; }
        public string? Organization { get; set; }
        public string? Asn { get; set; }
        public int  GeonameId { get; set; }
        public Currency? Currency { get; set; }
        public TimeZone? TimeZone { get; set; }
    }
}
