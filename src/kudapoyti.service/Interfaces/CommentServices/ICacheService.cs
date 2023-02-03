using kudapoyti.Service.Dtos.AccountDTOs;

namespace kudapoyti.Service.Interfaces.CommentServices
{
    public interface ICacheService
    {
        public Task SetValueAsync(string email, string code, UserValidateDto user);
        public Task<(string, UserValidateDto)> GetValueAsync(string email);
    }
}
