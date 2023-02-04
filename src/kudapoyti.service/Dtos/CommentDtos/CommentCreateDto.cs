using kudapoyti.Domain.Entities.Comment;
using kudapoyti.Service.Common.Helpers;
using kudapoyti.Service.Helpers;
using System.ComponentModel.DataAnnotations;

namespace kudapoyti.Service.Dtos.CommentDtos
{
    public class CommentCreateDto
    {
        [Required]
        public string Comments { get; set; }=String.Empty;

        [Required]
        public string UserName { get; set; }= String.Empty;

        [Required]
        public long PlaceId { get; set; }
        public static implicit operator Comment(CommentCreateDto dto)
        {
            return new Comment()
            {
                UserName=dto.UserName,
                Comments = dto.Comments,
                CreatedAt = TimeHelper.GetCurrentServerTime(),

            };
        }
    }

}
