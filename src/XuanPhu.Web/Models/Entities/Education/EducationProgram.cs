namespace XuanPhu.Web.Models.Entities.Education
{
    public class EducationProgram : BaseEntity
    {
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();
        public string Language { get; set; } = "vi";

        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = "";
        public string DetailHtml { get; set; } = "";

        public bool IsActive { get; set; } = true;
        public int OrderIndex { get; set; }

        public int? ThumbnailId { get; set; }
        public MediaFile? Thumbnail { get; set; }

        public ICollection<ProgramImage> Images { get; set; } = new List<ProgramImage>();
        public ICollection<ProgramDocument> Documents { get; set; } = new List<ProgramDocument>();
    }
}
