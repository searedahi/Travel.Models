
namespace Travel.Models
{
    public interface IProTip
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string ShortName { get; set; }
    }
}