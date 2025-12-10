namespace XuanPhu.Web.Models.Entities.Tourism
{
    public enum RegistrationStatus { New, InProgress, Done, Cancelled }
    public enum RegistrationSource { WebForm, Zalo, Phone }

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
