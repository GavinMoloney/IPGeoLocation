namespace GeoLocation.Models
{
    public class Geolocation
    {
        public string? ip { get; set; }
        public string? hostname { get; set; }
        public string? continent_code { get; set; }
        public string? continent_name { get; set; }
        public string? country_code2 { get; set; }
        public string? country_code3 { get; set; }
        public string? country_name { get; set; }
        public string? country_capital { get; set; }
        public string? state_prov { get; set; }
        public string? district { get; set; }
        public string? city { get; set; }
        public string? zipcode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public bool is_eu { get; set; }
        public string? calling_code { get; set; }
        public string? country_tld { get; set; }
        public string? languages { get; set; }
        public string? country_flag { get; set; }
        public string? isp { get; set; }
        public string? connection_type { get; set; }
        public string? organization { get; set; }
        public string? asn { get; set; }
        public int geoname_id { get; set; }
        public Currency? currency { get; set; }
        public TimeZone? time_zone { get; set; }
    }
}
