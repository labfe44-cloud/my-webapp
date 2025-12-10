namespace XuanPhu.Web.Models.Entities.Eventing
{
    public enum EventStatus { Upcoming, Ongoing, Past, Cancelled }

    public class Event : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = "";
        public string ContentHtml { get; set; } = "";

        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public string LocationText { get; set; } = "";
        public EventStatus Status { get; set; } = EventStatus.Upcoming;

        public bool IsFeatured { get; set; }

        public int? PosterImageId { get; set; }
        public MediaFile? PosterImage { get; set; }

        public ICollection<EventRegistration> Registrations { get; set; } = new List<EventRegistration>();
    }
}
