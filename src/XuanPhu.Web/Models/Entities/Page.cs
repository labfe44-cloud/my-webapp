using System.ComponentModel.DataAnnotations;

namespace XuanPhu.Web.Models.Entities
{
    public class Page : BaseEntity
    {
        // Multi-language group: các bản vi/en dùng chung GroupKey
        [Required, MaxLength(64)]
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();

        // "vi", "en" (tuỳ bạn manage)
        [Required, MaxLength(10)]
        public string Language { get; set; } = "vi";

        [Required, MaxLength(200)]
        public string Slug { get; set; } = null!;   // "ve-xuan-phu"

        [Required, MaxLength(255)]
        public string Title { get; set; } = null!;

        [MaxLength(255)]
        public string? Subtitle { get; set; }

        public string ContentHtml { get; set; } = "";

        [MaxLength(255)]
        public string? MetaTitle { get; set; }

        [MaxLength(500)]
        public string? MetaDescription { get; set; }

        [MaxLength(500)]
        public string? MetaKeywords { get; set; }

        public bool IsPublished { get; set; } = true;
    }

    public class SeoPopup : BaseEntity
    {
        public SeoPopup()
        {
        }

        [Required, MaxLength(255)]
        public string Title { get; set; } = null!;

        public string ContentHtml { get; set; } = null!;

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
