namespace Travel.Models
{
    public class CustomerTypeRate
    {
        public int Pk { get; set; }
        public int Total { get; set; }
        public int Capacity { get; set; }
        public ICustomerPrototype CustomerPrototype { get; set; }
        public ICustomerType CustomerType { get; set; }
    }
}
