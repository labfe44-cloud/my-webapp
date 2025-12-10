namespace XuanPhu.Web.Models.Entities
{
    public class SeoPopup : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string ContentHtml { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
