using kudapoyti.Domain.Common;

namespace kudapoyti.Domain.Entities.Comment;

public class Comment : Auditable
{
    public string Comments { get; set; } = String.Empty;

    public string UserEmail { get; set; } = String.Empty;

    public string UserName { get; set; } = String.Empty;

    public long PlaceId { get; set; }
    public virtual Places.Place Place { get; set; } = null!;
}
