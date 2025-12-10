namespace XuanPhu.Web.Models.Entities.Contacting
{
    public enum ContactSource { WebForm, Zalo, Phone, Other }
    public enum ContactStatus { New, InProgress, Done, Ignored }

    public class ContactRequest : BaseEntity
    {
        public string? Subject { get; set; }
        public string FullName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Message { get; set; } = null!;
        public ContactSource Source { get; set; } = ContactSource.WebForm;
        public ContactStatus Status { get; set; } = ContactStatus.New;
    }
}
