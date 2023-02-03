using kudapoyti.Domain.Entities.Comment;

namespace kudapoyti.Service.ViewModels
{
    public class CommentsViewModel
    {
        public string Comments { get; set; } = String.Empty;

        public string UserName { get; set; } = String.Empty;

        public static implicit operator CommentsViewModel(Comment comment)
        {
            return new()
            {
                Comments = comment.Comments,
                UserName = comment.UserName
            };
        }
    }
}
