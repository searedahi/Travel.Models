using System.Collections.Generic;

namespace Travel.Models
{
    public interface IAvailability
    {
        int Capactiy { get; set; }
        IList<ICustomerPrototype> CustomerTypeRates { get; set; }
        string EndAt { get; set; }
        int Pk { get; set; }
        string StartAt { get; set; }
    }
}