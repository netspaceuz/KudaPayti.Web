using kudapoyti.Service.Dtos.AccountDTOs;

namespace kudapoyti.Service.Interfaces.CommentServices
{
    public interface IEmailService
    {
        public Task SendAsync(UserValidateDto user);
    }
}
