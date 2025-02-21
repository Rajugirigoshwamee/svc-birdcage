using System.Threading.Tasks;

namespace svc.birdcage.hawk.Implementation.Repositories;

public class Repository<T> : IRepository<T> where T : BaseIdEntity
{
    public readonly DbContext _context;
    public DbSet<T> entity => _context.Set<T>();

    public Repository(DbContext dbContext)
    {
        _context = dbContext;
    }

    public void Add(T entity)
    {
        this.entity.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        this.entity.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return entity.ToList();
    }

    public T GetById(Guid id)
    {
        var entity = _context.Find<T>(id);
        return entity;
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }

    public async Task AddAsync(T entity)
    {
        await this.entity.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        this.entity.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await entity.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _context.FindAsync<T>(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}