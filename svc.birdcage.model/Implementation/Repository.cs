namespace svc.birdcage.model.Implementation;

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
        return this.entity.ToList();
    }

    public T GetById(int id)
    {
        var entity = _context.Find<T>(id);
        return entity;
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}