namespace Travel.Models
{
    public interface ICompany : IBaseTemplate
    {
        string Currency { get; set; }
        string Location { get; set; }
        string ShortName { get; set; }
        string About { get; set; }
        string AboutSafeHtml { get; set; }
        string BookingNotes { get; set; }
        string BookingNotesSafeHtml { get; set; }
        string Faq { get; set; }
        string FaqSafeHtml { get; set; }
        string Intro { get; set; }
        string IntroSafeHtml { get; set; }
        IAddressInfo Address { get; set; }
        IAddressInfo BillingAddress { get; set; }
        bool IsFareHarborVendor { get; set; }
    }
}