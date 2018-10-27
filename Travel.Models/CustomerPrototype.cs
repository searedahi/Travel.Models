namespace Travel.Models
{
    public class CustomerPrototype : ICustomerPrototype
    {
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        public int Pk { get; set; }
        public string DisplayName { get; set; }
        public int Total { get; set; }
        public int TravelMindedCustomerTypeId { get; set; }
    }
}
