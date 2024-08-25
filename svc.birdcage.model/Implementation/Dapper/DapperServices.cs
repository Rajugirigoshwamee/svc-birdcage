namespace svc.birdcage.model.Implementation.Dapper;

public class DapperServices<TConfig> : IDapperService
{
    private IDbConnection _connection;
    private TConfig _connectionString;

    public DapperServices()
    {
        this._connection = new SqlConnection(_connectionString!.ToString());
    }
    public Task<IEnumerable<T>> GetTableAsync<T>(string query, object parameters)
    {
        return _connection.QueryAsync<T>(query, param: parameters, commandType: CommandType.StoredProcedure);
    }

    public Task<int> AddOrUpdateAsync<T>(string query, object parameters)
    {
        return _connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
    }

    public T Find<T>(string query, object parameters)
    {
        return _connection.QueryFirstOrDefault<T>(query, param: parameters, commandType: CommandType.StoredProcedure) !;
    }

    public Task<T> FindAsync<T>(string query, object parameters)
    {
        return Task.Run(() =>
        {
            return Find<T>(query, parameters);
        });
    }
    public Task<SqlMapper.GridReader> GetMultipleAsync(string query, object parameters)
    {
        return _connection.QueryMultipleAsync(query, parameters, commandType: CommandType.StoredProcedure);
    }
}