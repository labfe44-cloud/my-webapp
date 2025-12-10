namespace XuanPhu.Web.Models.Entities
{
    public class Page : BaseEntity
    {
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();
        public string Language { get; set; } = "vi";
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Subtitle { get; set; }
        public string ContentHtml { get; set; } = "";
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public bool IsPublished { get; set; } = true;
    }
}
