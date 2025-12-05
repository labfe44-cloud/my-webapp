using System.ComponentModel.DataAnnotations;
using XuanPhu.Web.Models.Entities;

namespace XuanPhu.Web.Models.Entities.Season
{
    public class SeasonCard : BaseEntity
    {
        // Multi-language
        [Required, MaxLength(64)]
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();

        [Required, MaxLength(10)]
        public string Language { get; set; } = "vi";

        [Required, MaxLength(100)]
        public string SeasonName { get; set; } = null!; // "Mùa lúa chín"

        public int? FromMonth { get; set; }  // 1-12
        public int? ToMonth { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string ShortDescription { get; set; } = "";

        public string SuggestedItineraryHtml { get; set; } = "";

        public int OrderIndex { get; set; } = 0;

        public int? HeroImageId { get; set; }
        public MediaFile? HeroImage { get; set; }
    }
}
