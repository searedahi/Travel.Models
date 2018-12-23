using System;
using System.Collections.Generic;

namespace Travel.Models
{
    public class Availability : IAvailability
    {
        public int Pk { get; set; }
        public string StartAt { get; set; }
        public DateTime StartAtCasted
        {

            get
            {
                if (string.IsNullOrEmpty(StartAt))
                {
                    return new DateTime();
                }

                DateTime dt;
                DateTime.TryParse(StartAt, out dt);
                return dt;
            }
            set { }
        }
        public string EndAt { get; set; }
        public DateTime EndAtCasted
        {
            get
            {
                if (string.IsNullOrEmpty(EndAt))
                {
                    return new DateTime();
                }

                DateTime dt;
                DateTime.TryParse(EndAt, out dt);
                return dt;
            }
            set { }
        }

        public int Capactiy { get; set; }

        public IList<ICustomerTypeRate> CustomerTypeRates { get; set; }
    }
}
