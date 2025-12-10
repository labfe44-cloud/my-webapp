namespace XuanPhu.Web.Models.Entities.Season
{
    public class SeasonCard : BaseEntity
    {
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();
        public string Language { get; set; } = "vi";

        public string SeasonName { get; set; } = null!;
        public int? FromMonth { get; set; }
        public int? ToMonth { get; set; }

        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = "";
        public string SuggestedItineraryHtml { get; set; } = "";

        public int OrderIndex { get; set; } = 0;

        public int? HeroImageId { get; set; }
        public MediaFile? HeroImage { get; set; }
    }
}
