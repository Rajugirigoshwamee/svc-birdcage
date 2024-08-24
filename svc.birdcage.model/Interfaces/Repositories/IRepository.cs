namespace svc.birdcage.model.Repositories;

public interface IRepository<T> where T : BaseIdEntity
{
    public void Add(T entity);
    public void Delete(T entity);
    public void Update(T entity);
    public List<T> GetAll();
    public T GetById(Guid id);
    public Task AddAsync(T entity);
    public Task DeleteAsync(T entity);
    public Task UpdateAsync(T entity);
    public Task<List<T>> GetAllAsync();
    public Task<T?> GetByIdAsync(Guid id);
}