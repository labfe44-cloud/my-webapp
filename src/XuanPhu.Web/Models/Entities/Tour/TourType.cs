namespace XuanPhu.Web.Models.Entities.Tourism
{
    public class TourType : BaseEntity
    {
        public string GroupKey { get; set; } = Guid.NewGuid().ToString();
        public string Language { get; set; } = "vi";

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Tour> Tours { get; set; } = new List<Tour>();
    }
}
