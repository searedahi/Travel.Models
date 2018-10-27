namespace Travel.Models
{
    public interface IImageInfo
    {
        /// <summary>
        /// Fareharbor primary key.
        /// </summary>
        int Pk { get; set; }
        string Gallery { get; set; }
        int Id { get; set; }
        string ImageCdnUrl { get; set; }
    }
}