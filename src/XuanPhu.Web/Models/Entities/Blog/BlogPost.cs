namespace XuanPhu.Web.Models.Entities.Blog
{
    public enum BlogPostStatus { Draft, Published, Hidden }

    public class BlogPost : BaseEntity
    {
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();
        public string Language { get; set; } = "vi";

        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = "";
        public string ContentHtml { get; set; } = "";
        public DateTime? PublishedAt { get; set; }
        public BlogPostStatus Status { get; set; } = BlogPostStatus.Draft;
        public bool IsFeatured { get; set; }

        public int? CoverImageId { get; set; }
        public MediaFile? CoverImage { get; set; }

        public ICollection<BlogPostTag> BlogPostTags { get; set; } = new List<BlogPostTag>();
    }
}
