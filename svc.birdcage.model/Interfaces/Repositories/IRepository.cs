namespace svc.birdcage.model.Repositories;

public interface IRepository<T> where T : BaseIdEntity
{
    public void Add(T entity);
    public void Delete(T entity);
    public void Update(T entity);
    public List<T> GetAll();
    public T GetById(int id);
}