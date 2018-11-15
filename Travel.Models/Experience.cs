﻿using System;
using System.Collections.Generic;
using System.Linq;

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
        public string DescriptionShort
        {
            get
            {
                if (Description.Length > 160)
                {
                    return Description.Substring(0, 160);
                }
                return Description;

            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal TaxPercentage { get; set; }

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
        public IList<IAvailability> Availabilities { get; set; }

        public DateTime NextAvailableDate
        {
            get
            {
                if (Availabilities.Any())
                {
                    var startsAT = Availabilities.OrderBy(a => a.StartAt).FirstOrDefault().StartAt;
                    return DateTime.Parse(startsAT);
                }
                else
                {
                    return DateTime.Now;
                }
            }
            set
            { }
        }
        public string NextAvailableDateFormatted
        {
            get
            {
                if (Availabilities.Any())
                {
                    var startsAT = Availabilities.OrderBy(a => a.StartAt).FirstOrDefault().StartAt;
                    var nextDate = DateTime.Parse(startsAT);

                    if (nextDate.DayOfYear.Equals(DateTime.Now.DayOfYear))
                    {
                        return $"Today at {nextDate.TimeOfDay}";
                    }
                    else if (nextDate.CompareTo(DateTime.Now.AddDays(6)) < 6)
                    {
                        return $"This {nextDate.DayOfWeek.ToString()} at {nextDate.TimeOfDay}";
                    }
                    else
                    {
                        return nextDate.ToString("mmm DD");
                    }

                }
                else
                {
                    return "Call for availablilty.";
                }
            }
            set
            { }
        }
    }
}
