using System;
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
        public string DurationFormatted
        {
            get
            {
                if (Duration > 0)
                {
                    int remainder = 0;
                    var hours = Math.DivRem(Duration, 60, out remainder);

                    var formattedDuration = $"{hours / 60} hours";

                    if (hours < 1)
                    {
                        return $"{Duration} minutes.";
                    }

                    if (remainder > 0)
                    {
                        formattedDuration = $"{hours} - {hours + 1} hours";
                    }
                    return formattedDuration;
                }
                else
                {
                    return "Varies, see details.";
                }
            }
            set { }
        }
        public string Currency { get; set; }
        public string Location { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string DescriptionShort
        {
            get
            {
                if (Description != null && Description.Length > 160)
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
        public IList<IProTip> ProTips { get; set; }
        public IList<IAvailability> Availabilities { get; set; }


        private IAvailability _nextAvailability;
        public IAvailability NextAvailability
        {
            get
            {
                if (_nextAvailability != null && DateTime.Parse(_nextAvailability.StartAt).Year != 1)
                {
                    return _nextAvailability;
                }

                if (Availabilities != null && Availabilities.Any())
                {
                    var avail = Availabilities
                        .OrderBy(a => DateTime.Parse(a.StartAt))
                        .FirstOrDefault();

                    _nextAvailability = avail;
                    return _nextAvailability;
                }
                else
                {
                    return null;
                }
            }
            set
            { }
        }

        private DateTime _nextAvailableDate;
        public DateTime NextAvailableDate
        {
            get
            {
                if (_nextAvailableDate.Year != 1)
                {
                    return _nextAvailableDate;
                }

                if (NextAvailability != null)
                {
                    var dtOffset = DateTimeOffset.Parse(NextAvailability.StartAt);
                    _nextAvailableDate = dtOffset.DateTime;
                    return _nextAvailableDate;
                }
                else
                {
                    return DateTime.Now.AddYears(1);
                }
            }
            set
            { }
        }
        public string NextAvailableDateFormatted
        {
            get
            {
                TimeSpan ts = NextAvailableDate - DateTime.Now;

                if (ts.Hours >= 3)
                {
                    TimeSpan diff = DateTime.Now.AddDays(6) - NextAvailableDate;
                    if (diff.TotalDays >= 0 && diff.TotalDays <= 6)
                    {
                        // traps end of year
                        return $"This {NextAvailableDate.DayOfWeek.ToString()} at {NextAvailableDate.ToString("h:mm tt")}";
                    }
                    else if (!NextAvailableDate.Year.Equals(DateTime.Now.Year))
                    {
                        return $"Next {NextAvailableDate.ToString("MMM dd, yyyy")}";
                    }
                    else
                    {
                        //Normal middle of the year dates
                        if (NextAvailableDate.DayOfYear.Equals(DateTime.Now.DayOfYear))
                        {
                            return $"Today at {NextAvailableDate.ToString("h:mm tt")}";
                        }
                        else
                        {
                            return $"{NextAvailableDate.ToString("MMM dd, yyyy")} at { NextAvailableDate.ToString("h:mm tt")}";
                        }
                    }
                }
                else if(ts.Hours >= 0)
                {
                    return "It's too soon before the start to book online.  Call for availablilty.";
                }
                else
                {
                    return "Call Marty McFly, that's in the past...";
                }
            }
            set
            { }
        }

        public decimal CurrentAdultPrice
        {
            get
            {
                if (CustomerPrototypes != null && CustomerPrototypes.Any())
                {
                    var prices = CustomerPrototypes
                        .Where(p => p.DisplayName.Contains("adult", StringComparison.CurrentCultureIgnoreCase))
                        .Select(p => p.Total)
                        .ToList();

                    if (prices != null && prices.Any())
                    {
                        decimal maxPrice = prices.Max();

                        return (maxPrice / 100);
                    }
                }

                return 0;
            }
            set { }
        }
    }
}
