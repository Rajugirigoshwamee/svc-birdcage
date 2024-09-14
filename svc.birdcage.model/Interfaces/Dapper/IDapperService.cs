namespace svc.birdcage.model.Interfaces.Dapper;

public interface IDapperService
{
    List<T> GetTable<T>(string query, object parameters, CommandType type = CommandType.StoredProcedure);

    Task<IEnumerable<T>> GetTableAsync<T>(string query, object parameters, CommandType type = CommandType.StoredProcedure);

    SqlMapper.GridReader GetTables(string query, object parameters, CommandType type = CommandType.StoredProcedure);

    Task<SqlMapper.GridReader> GetTablesAsync(string query, object parameters, CommandType type = CommandType.StoredProcedure);

    T Find<T>(string query, object primarykeyFields, CommandType type = CommandType.StoredProcedure);

    Task<T> FindAsync<T>(string query, object primarykeyFields, CommandType type = CommandType.StoredProcedure);

    int AddOrUpdate<T>(string query, T entity, CommandType type = CommandType.StoredProcedure);

    Task<int> AddOrUpdateAsync<T>(string query, T entity, CommandType type = CommandType.StoredProcedure);

    int AddOrUpdate<T>(string query, IEnumerable<T> entities, CommandType type = CommandType.StoredProcedure);

    Task<int> AddOrUpdateAsync<T>(string query, IEnumerable<T> entities, CommandType type = CommandType.StoredProcedure);

    T AddOrUpdateAndGet<T>(string query, T entity, CommandType type = CommandType.StoredProcedure);
}
