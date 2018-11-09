﻿namespace Travel.Models
{
    public class AddressInfo : BaseTemplateWithPk, IAddressInfo
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
