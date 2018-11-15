namespace Travel.Models
{
    public interface ICustomerTypeRate
    {
        int Capacity { get; set; }
        ICustomerPrototype CustomerPrototype { get; set; }
        ICustomerType CustomerType { get; set; }
        int Pk { get; set; }
        int Total { get; set; }
    }
}