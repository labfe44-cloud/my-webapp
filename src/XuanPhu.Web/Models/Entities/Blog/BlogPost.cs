namespace XuanPhu.Web.Models.Entities.Blog
{
    public enum BlogPostStatus
    {
        Draft = 0,
        Published = 1,
        Hidden = 2
    }

    public class BlogPost : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = "";
        public string ContentHtml { get; set; } = "";
        public DateTime? PublishedAt { get; set; }
        public BlogPostStatus Status { get; set; } = BlogPostStatus.Draft;
        public bool IsFeatured { get; set; }

        // FK -> MediaFile (ảnh cover)
        public int? CoverImageId { get; set; }
        public MediaFile? CoverImage { get; set; }
    }
}
