using Api.Models;

namespace Api.Data;

public interface IRepository<T>
{
    IEnumerable<T> Get();
    T? GetById(int id);
    T Insert(T entity);
    void Delete(int id);
    void Update(T entity);
    void Save();
}

public interface IAccountRepository<T> : IRepository<T>
{
    T GetByUserName(string userName);
}

public interface IListingRepository<T> : IRepository<T>
{
    IEnumerable<T> GetListing(IFilter<T>? filter = null, Pagination? page = null, SortOrder? sortOrder = null);
    IFilter<T> GetFilterData();
}

public interface ICategoryRepository<T> : IRepository<T>
{
    bool IsEmpty(int id);
}
