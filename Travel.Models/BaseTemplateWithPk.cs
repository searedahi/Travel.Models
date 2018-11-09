namespace Travel.Models
{
    public class BaseTemplateWithPk : BaseTemplate, IBaseTemplateWithPk
    {
        public int Pk { get; set; }
    }
}
