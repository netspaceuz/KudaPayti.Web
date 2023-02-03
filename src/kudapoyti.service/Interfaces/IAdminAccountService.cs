using kudapoyti.Service.Dtos.Accounts;

namespace kudapoyti.Service.Interfaces
{
    public interface IAdminAccountService
    {
        public Task<string> LoginAsync(AdminAccountLoginDto account);
    }
}
