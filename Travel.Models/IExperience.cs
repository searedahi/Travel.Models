using System.Collections.Generic;

namespace Travel.Models
{
    public interface IExperience : IProduct
    {
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        int Pk { get; set; }
        int Duration { get; set; }
        string Headline { get; set; }
        string DescriptionSafeHtml { get; set; }
        string DescriptionText { get; set; }
        string CancellationPolicy { get; set; }
        string CancellationPolicySafeHtml { get; set; }
        string Location { get; set; }
        string ImageCdnUrl { get; set; }
        bool IsPickupEverOffered { get; set; }
        IList<string> DescriptionBullets { get; set; }
        IList<ICustomerPrototype> CustomerPrototypes { get; set; }
        IList<IImageInfo> Images { get; set; }
        IList<ILocationInfo> Locations { get; set; }
    }
}