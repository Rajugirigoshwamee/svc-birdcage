namespace svc.birdcage.hawk.Repositories;

public interface IRepository<T> where T : BaseIdEntity
{

    #region Add Records

    public void Add(T entity);
    public Task AddAsync(T entity);

    #endregion

    #region Update Records

    public void Update(T entity);
    public Task UpdateAsync(T entity);

    #endregion

    #region Find All Records

    public List<T> FindAll();
    public Task<List<T>> FindAllAsync();

    #endregion

    #region Delete Records

    public void Delete(T entity);
    public Task DeleteAsync(T entity);

    #endregion

    #region Find By Id Records

    public T FindById(Guid id);
    public Task<T?> FindByIdAsync(Guid id);

    #endregion

}