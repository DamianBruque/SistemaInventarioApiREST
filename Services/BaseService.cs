
using Utililies;
using Repositories;
using Services.Abstractions;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">entity</typeparam>
    /// <typeparam name="U">dto</typeparam>
    public class BaseService<T,U> : IBaseService<T,U> where T : class where U : class
    {
        private readonly IBaseRepository<T> _repository;
        
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public async Task<U> Create(U entity)
        {
            var result = await _repository.Create(Utilities.Map<T,U>(entity));
            return Utilities.Map<U, T>(result);
        }
        public async Task<bool> Update(int id, U entity)
        {
            return await _repository.Update(id, Utilities.Map<T, U>(entity));
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }
        public async Task<U> GetById(int id)
        {
            var result = await _repository.GetById(id);
            return Utilities.Map<U, T>(result);
        }
        public async Task<IEnumerable<U>> GetAll()
        {
            var results = await _repository.GetAll();
            return results.Select(entity => Utilities.Map<U, T>(entity));
        }  
    }
}
