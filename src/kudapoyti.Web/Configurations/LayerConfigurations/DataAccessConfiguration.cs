using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces;
using kudapoyti.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace kudapoyti.Web.Configurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {

        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection")!;
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
