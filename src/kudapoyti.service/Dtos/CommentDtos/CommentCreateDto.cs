using kudapoyti.Domain.Entities.Comment;
using kudapoyti.Service.Common.Helpers;
using kudapoyti.Service.Helpers;
using System.ComponentModel.DataAnnotations;

namespace kudapoyti.Service.Dtos.CommentDtos
{
    public class CommentCreateDto
    {
        [Required]
        public string Comments { get; set; }
        [Required]
        public int PlaceId { get; set; }
        public static implicit operator Comment(CommentCreateDto dto)
        {
            return new Comment()
            {
                Comments = dto.Comments,
                PlaceId = dto.PlaceId,
                CreatedAt = TimeHelper.GetCurrentServerTime(),
                UserEmail = TokenService.GetValue(CurrenUser.Token, "emailaddress"),
                UserName = TokenService.GetValue(CurrenUser.Token, "name")
            };
        }
    }

}
