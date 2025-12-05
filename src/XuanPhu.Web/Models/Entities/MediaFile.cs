using System.ComponentModel.DataAnnotations;

namespace XuanPhu.Web.Models.Entities
{
    public enum MediaFileType
    {
        Image = 0,
        Pdf = 1,
        Other = 2
    }

    public class MediaFile : BaseEntity
    {
        [Required, MaxLength(255)]
        public string FileName { get; set; } = null!;

        [Required, MaxLength(1000)]
        public string Url { get; set; } = null!;

        public MediaFileType FileType { get; set; } = MediaFileType.Image;

        [MaxLength(500)]
        public string? AltText { get; set; }

        public long SizeInBytes { get; set; }
    }
}
