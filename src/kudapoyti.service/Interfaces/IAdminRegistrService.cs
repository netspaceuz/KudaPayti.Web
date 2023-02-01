using kudapoyti.Service.Dtos.AdminAccountDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kudapoyti.Service.Interfaces
{
    public interface IAdminRegistrService
    {
        Task<bool> LoginAsync();
        public Task<bool> RegisterAsync(AdminRegisterDto account);
    }
}
