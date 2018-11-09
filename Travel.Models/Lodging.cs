namespace Travel.Models
{
    public class Lodging : BaseTemplateWithPk, ILodging
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public bool IsSelfLodging { get; set; }
        public bool IsPickupAvailable { get; set; }
    }
}
