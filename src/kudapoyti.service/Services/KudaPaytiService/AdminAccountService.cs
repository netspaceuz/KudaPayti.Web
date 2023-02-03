using kudapoyti.DataAccess.Interfaces;
using kudapoyti.Service.Common.Exceptions;
using kudapoyti.Service.Common.Security;
using kudapoyti.Service.Dtos.Accounts;
using kudapoyti.Service.Interfaces;

namespace kudapoyti.Service.Services.kudapoytiService
{
    public class AdminAccountService : IAdminAccountService
    {
        private readonly IUnitOfWork _work;
        private readonly IAuthManager _auth;

        public AdminAccountService(IUnitOfWork repository, IAuthManager authManager)
        {
            _work = repository;
            _auth = authManager;

        }

        public async Task<string> LoginAsync(AdminAccountLoginDto loginDto)
        {
            var admin = await _work.Admins.FirstOrDefaoultAsync(x => x.Email == loginDto.Email);
            if (admin is null) throw new ModelErrorException(nameof(loginDto.Email), "Admin not found, Email is incorrect!");

            var hasherResult = PasswordHasher.Verify(loginDto.Password, admin.Salt, admin.PasswordHash);
            if (hasherResult)
            {
                return _auth.GenerateToken(admin);
            }
            else throw new ModelErrorException(nameof(loginDto.Password), "Password is wrong!");

        }

    }
}
