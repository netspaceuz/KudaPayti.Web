namespace kudapoyti.Service.Interfaces.Common
{
    public interface IPaginationService
    {
        public Task<IList<T>> ToPagedAsync<T>(IQueryable<T> items, int pageNumber, int pageSize);

    }
}
