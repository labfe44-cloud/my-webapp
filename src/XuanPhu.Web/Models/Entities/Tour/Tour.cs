namespace XuanPhu.Web.Models.Entities.Tourism
{
    public class TourType : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Tour> Tours { get; set; } = new List<Tour>();
    }

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

    public enum RegistrationStatus
    {
        New = 0,
        InProgress = 1,
        Done = 2,
        Cancelled = 3
    }

    public enum RegistrationSource
    {
        WebForm = 0,
        Zalo = 1,
        Phone = 2
    }

    public class TourRegistration : BaseEntity
    {
        public int TourTypeId { get; set; }
        public TourType TourType { get; set; } = null!;

        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public int? NumberOfPeople { get; set; }
        public DateTime? PreferredDate { get; set; }
        public string? Note { get; set; }

        public RegistrationStatus Status { get; set; } = RegistrationStatus.New;
        public RegistrationSource Source { get; set; } = RegistrationSource.WebForm;
    }
}
