namespace XuanPhu.Web.Models.Entities.Eventing
{
    public class EventRegistration : BaseEntity
    {
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public int? NumberOfPeople { get; set; }
        public string? Note { get; set; }
    }
}
