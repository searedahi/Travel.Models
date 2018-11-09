namespace Travel.Models
{
    public interface IBaseTemplateWithPk : IBaseTemplate
    {
        int Pk { get; set; }
    }
}