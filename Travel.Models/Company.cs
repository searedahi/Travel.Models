namespace Travel.Models
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
        public bool IsFareHarborVendor { get; set; }
        public string About { get; set; }
        public string AboutSafeHtml { get; set; }
        public string BookingNotes { get; set; }
        public string BookingNotesSafeHtml { get; set; }
        public string Faq { get; set; }
        public string FaqSafeHtml { get; set; }
        public string Intro { get; set; }
        public string IntroSafeHtml { get; set; }
        public AddressInfo Address { get; set; }
        public AddressInfo BillingAddress { get; set; }
    }
}
