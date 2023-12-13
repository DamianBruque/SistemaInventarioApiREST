using Microsoft.EntityFrameworkCore;
using Repositories;

namespace DataAccess;

public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
{
    private readonly ProjectContext _context; 
    private readonly DbSet<T> _dbSet;
    public BaseRepository(ProjectContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T> Create(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Delete(int id)
    {
        bool result = false;
        var element = await _dbSet.FindAsync(id);
        if (element is not null)
        {
            _context.Remove(element);
            await _context.SaveChangesAsync();
            result = true;
        }
        return result;
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        var elements = await _dbSet.ToListAsync();
        return elements;
    }

    public async Task<T> GetById(int id)
    {
        var element = await _dbSet.FindAsync(id);
        return element;
    }

    public async Task<bool> Update(int id, T entity)
    {
        bool result = false;
        var element = await _dbSet.FindAsync(id);
        if (element is not null)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            result = true;
        }
        return result;
    }

}
