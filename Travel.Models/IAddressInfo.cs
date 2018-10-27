namespace Travel.Models
{
    public interface IAddressInfo
    {
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string Province { get; set; }
        string Street { get; set; }
    }
}