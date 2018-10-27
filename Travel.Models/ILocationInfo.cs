namespace Travel.Models
{
    public interface ILocationInfo
    {
        AddressInfo Address { get; set; }
        int Pk { get; set; }
        string GooglePlaceId { get; set; }
        decimal Latitude { get; set; }
        decimal Longitude { get; set; }
        string Note { get; set; }
        string NoteSafeHtml { get; set; }
        string TripadvisorUrl { get; set; }
        string Type { get; set; }
    }
}