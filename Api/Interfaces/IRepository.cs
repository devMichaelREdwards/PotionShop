namespace Api.Data;

public interface IRepository<T>
{
    IEnumerable<T> Get();
    IEnumerable<T> GetListing();
    T GetById(int id);
    T Insert(T entity);
    void Delete(int id);
    void Update(T entity);
    void Save();
}
