
namespace Repositories;

public interface IBaseRepository<T> where T : class
{
    Task<T> Create(T entity);
    Task<bool> Update(int id,T entity);
    Task<bool> Delete(int id);
    Task<T> GetById(int id);
    Task<IEnumerable<T>> GetAll();
}
