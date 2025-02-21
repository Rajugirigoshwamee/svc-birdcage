namespace svc.birdcage.hawk.Implementation.Dapper;

public class DapperServices : IDapperService
{
    private IDbConnection _connection;
    private int? CommandTimeout = 0;
    private IDbTransaction? Transaction = null;

    public DapperServices(string connectionString)
    {
        this._connection = new SqlConnection(connectionString);
    }

    #region Add or Update single or multiple records.

    public int AddOrUpdate<T>(string query, T entity, CommandType type = CommandType.StoredProcedure)
    {
        if (_connection == null)
            throw new ArgumentNullException(nameof(entity), $"The parameter {nameof(entity)} can't be null");
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(entity, nameof(entity));
        int result = _connection.Execute(query, entity, Transaction, CommandTimeout, type);
        return result;
    }

    public int AddOrUpdate<T>(string query, IEnumerable<T> entities, CommandType type = CommandType.StoredProcedure)
    {
        if (_connection == null)
            throw new ArgumentNullException(nameof(entities), $"The parameter {nameof(entities)} can't be null");
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateEnumerable(entities, nameof(entities));
        int result = _connection.Execute(query, entities, Transaction, CommandTimeout, type);
        return result;
    }

    public Task<int> AddOrUpdateAsync<T>(string query, T entity, CommandType type = CommandType.StoredProcedure)
    {
        if (_connection == null)
            throw new ArgumentNullException(nameof(entity), $"The parameter {nameof(entity)} can't be null");
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(entity, nameof(entity));
        var result = _connection.ExecuteAsync(query, entity, Transaction, CommandTimeout, type);
        return result;
    }

    public Task<int> AddOrUpdateAsync<T>(string query, IEnumerable<T> entities, CommandType type = CommandType.StoredProcedure)
    {
        if (_connection == null)
            throw new ArgumentNullException(nameof(entities), $"The parameter {nameof(entities)} can't be null");
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateEnumerable(entities, nameof(entities));
        var result = _connection.ExecuteAsync(query, entities, Transaction, CommandTimeout, type);
        return result;
    }

    #endregion Add or Update single or multiple records.

    #region Get record by Id.

    public T Find<T>(string query, object primarykeyFields, CommandType type = CommandType.StoredProcedure)
    {
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(primarykeyFields, nameof(primarykeyFields));
        return _connection.QueryFirstOrDefault<T>(query, primarykeyFields, Transaction, CommandTimeout, type);
    }

    public Task<T> FindAsync<T>(string query, object primarykeyFields, CommandType type = CommandType.StoredProcedure)
    {
        return Task.Run(() =>
        {
            return Find<T>(query, primarykeyFields, type);
        });
    }

    #endregion Get record by Id.

    #region Get tables

    public List<T> GetTable<T>(string query, object parameters, CommandType type = CommandType.StoredProcedure)
    {
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(parameters, nameof(parameters));
        return _connection.Query<T>(query, parameters, null, true, CommandTimeout, type).ToList();
    }

    public Task<IEnumerable<T>> GetTableAsync<T>(string query, object parameters, CommandType type = CommandType.StoredProcedure)
    {
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(parameters, nameof(parameters));
        return _connection.QueryAsync<T>(query, parameters, Transaction, CommandTimeout, type);
    }

    #endregion Get tables

    #region Get more than one tables

    public SqlMapper.GridReader GetTables(string query, object parameters, CommandType type = CommandType.StoredProcedure)
    {
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(parameters, nameof(parameters));
        return _connection.QueryMultiple(query, parameters, Transaction, CommandTimeout, type);
    }

    public Task<SqlMapper.GridReader> GetTablesAsync(string query, object parameters, CommandType type = CommandType.StoredProcedure)
    {
        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(parameters, nameof(parameters));
        return _connection.QueryMultipleAsync(query, parameters, Transaction, CommandTimeout, type);
    }

    #endregion Get more than one tables

    #region Add or Update single or multiple records & get result.

    public T AddOrUpdateAndGet<T>(string query, T entity, CommandType type = CommandType.StoredProcedure)
    {
        if (_connection == null) throw new ArgumentNullException(nameof(entity), $"The parameter {nameof(entity)} can't be null");

        ParameterValidator.ValidateString(query, nameof(query));
        ParameterValidator.ValidateObject(entity, nameof(entity));

        var result = _connection.QueryFirstOrDefault<T>(query, entity, Transaction, CommandTimeout, type);

        return result;
    }

    #endregion Add or Update single or multiple records & get result.

    #region House Keeping

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();

            _connection.Dispose();
            Transaction = null;
            CommandTimeout = null;
        }
    }

    #endregion House Keeping
}