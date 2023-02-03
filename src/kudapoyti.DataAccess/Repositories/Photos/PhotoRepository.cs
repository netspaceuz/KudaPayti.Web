using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces.Photos;
using kudapoyti.Domain.Entities.Photos;

namespace kudapoyti.DataAccess.Repositories.Photos;

public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
{
    public PhotoRepository(AppDbContext context) : base(context)
    {

    }
}
