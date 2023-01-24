using kudapoyti.DataAccess.Interfaces;
using kudapoyti.DataAccess.Repositories;
using kudapoyti.Service.Common.Security;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.Services.KudaPaytiService;

namespace KudaPayti.Web.Configurations.LayerConfigurations
{
    public static class  ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAdminRegistrService, AdminRegistrService>();
            services.AddScoped<IAuthManager, AUthManager>();
            services.AddScoped<IAdminAccountService, AdminAccountService>();
        }

     
    }
}
