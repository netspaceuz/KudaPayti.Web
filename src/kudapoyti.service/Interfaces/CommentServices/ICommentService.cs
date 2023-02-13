using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos.CommentDtos;
using kudapoyti.Service.ViewModels;

namespace kudapoyti.Service.Interfaces.CommentServices
{
    public interface ICommentService
    {
        public Task<bool> CreateAsync(CommentCreateDto createDto);
        public Task<PagedList<CommentsViewModel>> GetByPlaceId(long id, PaginationParams @params);
        public Task<bool> DeleteAsync(long id);
    }
}
