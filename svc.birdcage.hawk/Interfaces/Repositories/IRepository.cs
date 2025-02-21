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

    #region Get All Records

    public List<T> GetAll();
    public Task<List<T>> GetAllAsync();

    #endregion

    #region Delete Records

    public void Delete(T entity);
    public Task DeleteAsync(T entity);

    #endregion

    #region Get By Id Records
    public T GetById(Guid id);
    public Task<T?> GetByIdAsync(Guid id);

    #endregion

}