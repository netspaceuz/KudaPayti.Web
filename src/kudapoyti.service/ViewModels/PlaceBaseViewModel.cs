namespace kudapoyti.Service.ViewModels;

public class PlaceBaseViewModel
{
    public long Id { get; set; }

    public string ImageUrl { get; set; } = String.Empty;

    public string Title { get; set; } = string.Empty;

    public string Region { get; set; } = String.Empty;

    public double rank { get; set; }

    public string PlaceSiteUrl { get; set; } = String.Empty;

    public string Description { get; set; } = string.Empty;

    public long rankedUsersCount { get; set; }

    public string Location_link { get; set; } = String.Empty;

    public DateTime CreatedAt { get; set; }
}
