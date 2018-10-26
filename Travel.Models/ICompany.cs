namespace Experience.Models
{
    public interface ICompany : IBaseTemplate
    {
        string Currency { get; set; }
        string Location { get; set; }
        string ShortName { get; set; }
    }
}