namespace XuanPhu.Web.Models.Entities
{
    public enum MediaFileType { Image, Pdf, Other }

    public class MediaFile : BaseEntity
    {
        public string FileName { get; set; } = null!;
        public string Url { get; set; } = null!;
        public MediaFileType FileType { get; set; }
        public string? AltText { get; set; }
        public long SizeInBytes { get; set; }
    }
}
