﻿using System.Collections.Generic;

namespace Travel.Models
{
    public class Experience : IExperience
    {
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        public int Pk { get; set; }
        public int Duration { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICompany Company { get; set; }
        public string Headline { get; set; }
        public string DescriptionSafeHtml { get; set; }
        public string DescriptionText { get; set; }
        public string CancellationPolicy { get; set; }
        public string CancellationPolicySafeHtml { get; set; }
        public string ImageCdnUrl { get; set; }
        public bool IsPickupEverOffered { get; set; }
        public IList<string> DescriptionBullets { get; set; }
        public IList<ICustomerPrototype> CustomerPrototypes { get; set; }
        public IList<IImageInfo> Images { get; set; }
        public IList<ILocationInfo> Locations { get; set; }
    }
}
