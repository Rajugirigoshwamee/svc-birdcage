namespace svc.birdcage.model.Interfaces.Dapper;

public interface IDapperService
{
    Task<IEnumerable<T>> GetTableAsync<T>(string query, object parameters);
    Task<int> AddOrUpdateAsync<T>(string query, object parameters);
    Task<T> FindAsync<T>(string query, object parameters);
    public Task<SqlMapper.GridReader> GetMultipleAsync(string query, object parameters);
}
