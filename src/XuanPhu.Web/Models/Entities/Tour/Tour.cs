namespace XuanPhu.Web.Models.Entities.Tourism
{
    public class Tour : BaseEntity
    {
        public int TourTypeId { get; set; }
        public TourType TourType { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string ShortDescription { get; set; } = "";
        public string DetailHtml { get; set; } = "";

        public string? Duration { get; set; }
        public decimal? PriceFrom { get; set; }

        public int? ThumbnailId { get; set; }
        public MediaFile? Thumbnail { get; set; }
    }
}
