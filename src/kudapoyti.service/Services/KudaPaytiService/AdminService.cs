using AutoMapper;
using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces;
using kudapoyti.Domain.Entities.Admins;
using kudapoyti.Service.Common.Exceptions;
using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.Interfaces.Common;
using kudapoyti.Service.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace kudapoyti.Service.Services.kudapoytiService
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _work;
        private readonly IImageService _image;
        private readonly IPaginationService _pager;
        private readonly IMapper _mapper;
        private readonly AppDbContext appDb;
        public AdminService(IUnitOfWork repository, AppDbContext appDb, IMapper mapper, IPaginationService pagination, IImageService image)
        {
            this._work = repository;
            this._mapper = mapper;
            this.appDb = appDb;
            this._image = image;
            this._pager = pagination;
        }
        public async Task<bool> DeleteAysnc(long id)
        {
            var delete = await _work.Admins.FindByIdAsync(id);
            if (delete is not null)
            {
                _work.Admins.DeleteAsync(id);
                var result = await _work.SaveChangesAsync();
                return result > 0;
            }
            else throw new NotFoundException(HttpStatusCode.NotFound, "Admin not found");
        }

        public async Task<PagedList<AdminViewModel>> GetAllAysnc(PaginationParams @params)
        {
            var query = from product in _work.Admins.GetAll().OrderBy(x => x.Id)
                        select new AdminViewModel()
                        {
                            Id = product.Id,
                            FullName = product.FullName,
                            Email = product.Email,
                            PhoneNumber = product.PhoneNumber,
                            TelegramLink = product.TelegramLink

                        };
            return await PagedList<AdminViewModel>.ToPagedListAsync(query, @params);
        }
        public async Task<AdminViewModel> GetAysnc(long id)
        {
            var get = await _work.Admins.FindByIdAsync(id);
            if (get is not null)
            {
                AdminViewModel product = new AdminViewModel()
                {
                    Id = get.Id,
                    FullName = get.FullName,
                    Email = get.Email,
                    PhoneNumber = get.PhoneNumber,
                    TelegramLink = get.TelegramLink,
                };

                return product;
            }
            else throw new NotFoundException(HttpStatusCode.NotFound, "Admin not faund");
        }


        public async Task<bool> UpdateAysnc(long id, UpdateCreateDto dto)
        {
            var update = await appDb.Admins.FindAsync(id);
            appDb.Entry<Admin1>(update!).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            if (dto is not null)
            {
                var res = _mapper.Map<Admin1>(dto);
                res.Id = id;
                appDb.Admins.Update(res);
                var result = await appDb.SaveChangesAsync();
                return result > 0;
            }
            else throw new NotFoundException(HttpStatusCode.NotFound, "Admin not faund");
        }
    }
}
