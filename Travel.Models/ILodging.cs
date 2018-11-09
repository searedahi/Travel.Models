namespace Travel.Models
{
    public interface ILodging: IBaseTemplateWithPk
    {
        string Address { get; set; }
        bool IsSelfLodging { get; set; }
        bool IsPickupAvailable { get; set; }
        string Phone { get; set; }
        string Url { get; set; }
    }
}