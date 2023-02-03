using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces.Admins;
using kudapoyti.Domain.Entities.Admins;

namespace kudapoyti.DataAccess.Repositories.Admins;

public class AdminRepository : GenericRepository<Admin1>, IAdminRepository
{
    public AdminRepository(AppDbContext context) : base(context)
    {

    }
}
