namespace XuanPhu.Web.Models.Entities.Map
{
    public class JourneyRoute : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? PolylineData { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<JourneyStop> Stops { get; set; } = new List<JourneyStop>();
    }
}
