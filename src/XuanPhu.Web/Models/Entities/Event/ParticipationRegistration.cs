namespace XuanPhu.Web.Models.Entities.Eventing
{
    public enum ParticipationFormType { JoinEvent, Volunteer, Experience, Other }
    public enum ParticipationStatus { New, InProgress, Done, Cancelled }

    public class ParticipationRegistration : BaseEntity
    {
        public ParticipationFormType FormType { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public DateTime? PreferredDate { get; set; }
        public string? Message { get; set; }
        public ParticipationStatus Status { get; set; }
    }
}
