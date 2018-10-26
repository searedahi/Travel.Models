namespace Experience.Models
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
    }
}
