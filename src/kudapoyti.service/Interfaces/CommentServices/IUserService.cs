using kudapoyti.Service.Dtos.AccountDTOs;

namespace kudapoyti.Service.Interfaces.CommentServices
{
    public interface IUserService
    {
        public Task LoginAsync(UserValidateDto userValidate);
        public Task<(bool, string)> VerifyCodeAsync(string email, string code);
    }
}
