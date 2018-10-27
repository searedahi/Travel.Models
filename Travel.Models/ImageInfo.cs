namespace Travel.Models
{
    public class ImageInfo : IImageInfo
    {
        public int Id { get; set; }
        public int Pk { get; set; }
        public string Gallery { get; set; }
        public string ImageCdnUrl { get; set; }
    }
}
