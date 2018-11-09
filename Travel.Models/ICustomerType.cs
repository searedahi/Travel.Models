namespace Travel.Models
{
    public interface ICustomerType
    {
        string Note { get; set; }
        int Pk { get; set; }
        string Plural { get; set; }
        string Singular { get; set; }
    }
}