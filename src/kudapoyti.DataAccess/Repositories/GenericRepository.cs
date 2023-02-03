using kudapoyti.DataAccess.DbConstexts;
using kudapoyti.DataAccess.Interfaces;
using kudapoyti.Domain.Common;
using System.Linq.Expressions;

namespace kudapoyti.DataAccess.Repositories;

public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T>
    where T : BaseEntity
{
    public GenericRepository(AppDbContext app) : base(app)
    {
    }

    public IQueryable<T> GetAll() => _dbset;

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        => _dbset.Where(expression);

}
