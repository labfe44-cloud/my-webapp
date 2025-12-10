namespace XuanPhu.Web.Models.Entities.Map
{
    public class JourneyStop : BaseEntity
    {
        public int JourneyRouteId { get; set; }
        public JourneyRoute JourneyRoute { get; set; } = null!;

        public int MapLocationId { get; set; }
        public MapLocation MapLocation { get; set; } = null!;

        public int OrderIndex { get; set; }
        public string? PopupTitle { get; set; }
        public string? PopupContent { get; set; }
    }
}
