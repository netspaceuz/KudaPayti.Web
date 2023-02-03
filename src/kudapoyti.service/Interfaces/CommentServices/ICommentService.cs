using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos.CommentDtos;
using kudapoyti.Service.ViewModels;

namespace kudapoyti.Service.Interfaces.CommentServices
{
    public interface ICommentService
    {
        public Task<bool> CreateAsync(CommentCreateDto createDto);
        public Task<IEnumerable<CommentsViewModel>> GetByPlaceId(long id, PaginationParams @paginationParams);
        public Task<bool> DeleteAsync(long id);
    }
}
