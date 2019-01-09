using Travel.Models;

namespace TravelMinded.Models
{
    public class ProTip : IBaseTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }

        //Navigation properties
        public IExperience Experience { get; set; }
        public IProduct Product { get; set; }

    }
}
