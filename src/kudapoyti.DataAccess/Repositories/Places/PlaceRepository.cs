using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces.Places;
using kudapoyti.Domain.Entities.Places;

namespace kudapoyti.DataAccess.Repositories.Places
{
    public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(AppDbContext context) : base(context)
        {

        }
    }
}
