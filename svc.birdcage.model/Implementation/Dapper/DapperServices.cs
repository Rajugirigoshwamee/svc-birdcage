namespace svc.birdcage.model.Implementation.Dapper;

public class DapperServices : IDapperService
{
    private IDbConnection _connection;

    public DapperServices(string connectionString)
    {
        this._connection = new SqlConnection(connectionString);
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