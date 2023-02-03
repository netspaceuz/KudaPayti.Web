using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos;
using kudapoyti.Service.ViewModels;

namespace kudapoyti.Service.Interfaces
{
    public interface IAdminService
    {
        public Task<IEnumerable<AdminViewModel>> GetAllAysnc(PaginationParams @params);
        public Task<AdminViewModel> GetAysnc(long id);
        public Task<bool> UpdateAysnc(long id, UpdateCreateDto dto);
        public Task<bool> DeleteAysnc(long id);

    }
}
