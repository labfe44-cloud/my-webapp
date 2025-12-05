namespace XuanPhu.Web.Models.Entities.Map
{
    public enum LocationType
    {
        Checkpoint = 0,
        Gate = 1,
        Parking = 2,
        Service = 3,
        ViewPoint = 4
    }

    public class MapLocation : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? GoogleMapsUrl { get; set; }
        public LocationType LocationType { get; set; } = LocationType.Checkpoint;
        public bool IsActive { get; set; } = true;
    }

    public class JourneyRoute : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? PolylineData { get; set; } // encoded polyline / JSON

        public bool IsActive { get; set; } = true;

        public ICollection<JourneyStop> Stops { get; set; } = new List<JourneyStop>();
    }

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
