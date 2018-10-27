namespace Travel.Models
{
    public interface IProduct : IBaseTemplate
    {
        ICompany Company { get; set; }
    }
}