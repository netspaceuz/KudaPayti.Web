using kudapoyti.DataAccess.Interfaces;
using kudapoyti.DataAccess.Repositories;
using kudapoyti.Service.Common.Security;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.Interfaces.CommentServices;
using kudapoyti.Service.Interfaces.Common;
using kudapoyti.Service.Services.CommentServices;
using kudapoyti.Service.Services.Common;
using kudapoyti.Service.Services.kudapoytiService;
using kudapoyti.Web.Configuration;

namespace kudapoyti.Web.Configurations.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAdminRegistrService, AdminRegistrService>();
            services.AddScoped<IAuthManager, AUthManager>();
            services.AddScoped<IAdminAccountService, AdminAccountService>();
            services.AddTransient<IPlaceService, PlaceService>();
            services.AddTransient<IPaginationService,PaginatonService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddMemoryCache();
            services.AddHttpContextAccessor();
            services.AddAutoMapper(typeof(MappingConfiguration));
        }


    }
}
