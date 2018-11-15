using System.Collections.Generic;

namespace Travel.Models
{
    public class Availability : IAvailability
    {
        public int Pk { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public int Capactiy { get; set; }

        public IList<ICustomerTypeRate> CustomerTypeRates { get;set;}
    }
}
