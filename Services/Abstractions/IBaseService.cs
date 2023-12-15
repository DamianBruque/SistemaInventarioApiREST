

namespace Services.Abstractions
{
    public interface IBaseService<T,U> where T : class where U : class
    {
        Task<U> Create(U entity);
        Task<bool> Update(int id,U entity);
        Task<bool> Delete(int id);
        Task<U> GetById(int id);
        Task<IEnumerable<U>> GetAll();
    }
}
