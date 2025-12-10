namespace XuanPhu.Web.Models.Entities.Contacting
{
    public class NewsletterSubscription : BaseEntity
    {
        public string Email { get; set; } = null!;
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? UnsubscribedAt { get; set; }
    }
}
