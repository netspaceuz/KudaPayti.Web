using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces.Comments;
using kudapoyti.Domain.Entities.Comment;

namespace kudapoyti.DataAccess.Repositories.Comments;

public class CommentRepository : GenericRepository<Comment>, ICommentsRepository
{
    public CommentRepository(AppDbContext context) : base(context)
    {

    }
}
