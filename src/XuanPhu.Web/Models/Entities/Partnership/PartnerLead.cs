using System.ComponentModel.DataAnnotations;
using XuanPhu.Web.Models.Entities;

namespace XuanPhu.Web.Models.Entities.Partnership
{
    public enum PartnerLeadType
    {
        Marketplace = 0,
        Partnership = 1,
        Other = 2
    }

    public enum PartnerLeadStatus
    {
        New = 0,
        Contacted = 1,
        Qualified = 2,
        Rejected = 3
    }

    public class PartnerLead : BaseEntity
    {
        public PartnerLeadType Type { get; set; } = PartnerLeadType.Marketplace;

        [MaxLength(255)]
        public string? CompanyName { get; set; }

        [Required, MaxLength(255)]
        public string ContactName { get; set; } = null!;

        [Required, MaxLength(255), EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MaxLength(20)]
        public string Phone { get; set; } = null!;

        [MaxLength(500)]
        public string? WebsiteUrl { get; set; }

        [MaxLength(255)]
        public string? ServiceCategory { get; set; }

        [MaxLength(2000)]
        public string? Message { get; set; }

        public PartnerLeadStatus Status { get; set; } = PartnerLeadStatus.New;
    }
}
