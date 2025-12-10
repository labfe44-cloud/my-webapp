namespace XuanPhu.Web.Models.Entities.Map
{
    public enum LocationType { Checkpoint, Gate, Parking, Service, ViewPoint }

    public class MapLocation : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? GoogleMapsUrl { get; set; }
        public LocationType LocationType { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
