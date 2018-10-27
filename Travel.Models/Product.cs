namespace Travel.Models
{

    public class Product : IProduct
    {
        public string ShortName { get; set; }
        public string Currency { get; set; }
        public ICompany Company { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
