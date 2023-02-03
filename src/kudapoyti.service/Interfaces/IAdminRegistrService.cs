using kudapoyti.Service.Dtos.AdminAccountDtos;


namespace kudapoyti.Service.Interfaces
{
    public interface IAdminRegistrService
    {

        public Task<bool> RegisterAsync(AdminRegisterDto account);
    }
}
