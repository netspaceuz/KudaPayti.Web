using kudapoyti.Domain.Common;

namespace kudapoyti.Domain.Entities.Photos
{
    public class Photo : BaseEntity
    {
        public string Photo_path { get; set; } = String.Empty;

        public long PlaceId { get; set; }
        public virtual Places.Place Place { get; set; } = null!;
    }
}

