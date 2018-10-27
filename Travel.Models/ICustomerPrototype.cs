namespace Travel.Models
{
    public interface ICustomerPrototype
    {
        string DisplayName { get; set; }
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        int Pk { get; set; }
        int Total { get; set; }
        int TravelMindedCustomerTypeId { get; set; }
    }
}