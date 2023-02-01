using kudapoyti.Domain.Entities.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.ViewModels
{
    public class PlaceViewModel:Attribute
    {
        public long Id { get; set; }

        public string ImageUrl { get; set; }=String.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public double rank { get; set; }

        public string Location_link { get; set; } = String.Empty;

        public string PlaceSiteUrl { get; set; } = String.Empty;

        public long rankedUsersCount { get; set; }

        public string Region { get; set; } = String.Empty;
        public DateTime CreatedAt { get; private set; }

        public static implicit operator PlaceViewModel(Place comment)
        {
            return new()
            {
                Id = comment.Id,
                ImageUrl = comment.ImageUrl,
                Title = comment.Title,
                Description = comment.Description,
                rank = comment.rank,
                Location_link = comment.Location_link,
                PlaceSiteUrl = comment.PlaceSiteUrl,
                Region = comment.Region,
                CreatedAt=comment.CreatedAt,
                rankedUsersCount=comment.rankedUsersCount

            };
        }

    } 
}
  