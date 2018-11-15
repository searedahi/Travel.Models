using System;
using System.Collections.Generic;

namespace Travel.Models
{
    public interface IExperience : IProduct, IBaseTemplateWithPk
    {
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        int Duration { get; set; }
        string Headline { get; set; }
        string Description { get; set; }
        string DescriptionShort { get; }
        string DescriptionSafeHtml { get; set; }
        string DescriptionText { get; set; }
        string CancellationPolicy { get; set; }
        string CancellationPolicySafeHtml { get; set; }
        string Location { get; set; }
        string ImageCdnUrl { get; set; }
        bool IsPickupEverOffered { get; set; }
        decimal TaxPercentage { get; set; }
        DateTime NextAvailableDate { get; set; }
        string NextAvailableDateFormatted { get; set; }

        IList<string> DescriptionBullets { get; set; }
        IList<ICustomerPrototype> CustomerPrototypes { get; set; }
        IList<IImageInfo> Images { get; set; }
        IList<ILocationInfo> Locations { get; set; }
        IList<IAvailability> Availabilities { get; set; }

    }
}