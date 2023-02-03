using kudapoyti.Domain.Common;
using System.Linq.Expressions;

namespace kudapoyti.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> FindByIdAsync(long id);

        public Task<T?> FirstOrDefaoultAsync(Expression<Func<T, bool>> expression);

        public void CreateAsync(T entity);

        public void DeleteAsync(long id);

        public void UpdateAsync(long id, T entity);
    }
}
