namespace Travel.Models
{
    public interface IBaseTemplate
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}