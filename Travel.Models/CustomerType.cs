namespace Travel.Models
{
    public class CustomerType : ICustomerType
    {
        public int Pk { get; set; }
        public string Singular { get; set; }
        public string Plural { get; set; }
        public string Note { get; set; }
    }
}
