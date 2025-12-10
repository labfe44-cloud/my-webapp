namespace XuanPhu.Web.Models.Entities.Partnership
{
    public enum PartnerLeadType { Marketplace, Partnership, Other }
    public enum PartnerLeadStatus { New, Contacted, Qualified, Rejected }

    public class PartnerLead : BaseEntity
    {
        public PartnerLeadType Type { get; set; }
        public string? CompanyName { get; set; }
        public string ContactName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? WebsiteUrl { get; set; }
        public string? ServiceCategory { get; set; }
        public string? Message { get; set; }
        public PartnerLeadStatus Status { get; set; } = PartnerLeadStatus.New;
    }
}
