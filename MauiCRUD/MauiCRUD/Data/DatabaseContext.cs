using SQLite;
using System.Linq.Expressions;

namespace Data
{
    public class DatabaseContext
    {
        private const string DbName = "CRUDdb3";
        private static string DbPath => Path.Combine(".", DbName);

        private SQLiteAsyncConnection _connection;

        private SQLiteAsyncConnection Database => (_connection ??= new SQLiteAsyncConnection(DbPath,
            SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache));

        public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.ToListAsync();
        }

        public async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return Database.Table<TTable>();
        }

        public async Task CreateTableIfNotExists<TTable>() where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();
        }

        public async Task<TResult> Execute<TTable, TResult>(Func<Task<TResult>> action) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await action();
        }
        public async Task<TTable> GetItemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            return await Execute<TTable, TTable>(async () => await Database.GetAsync<TTable>(primaryKey));
        }
        public async Task<bool> AddItemsAsync<TTable>(TTable item) where TTable : class, new()
        {
            return await Execute<TTable, bool>(async () => await Database.InsertAsync(item) > 0);
        }
        public async Task<bool> UpdateItemsAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(item) > 0;
        }
        public async Task<bool> DeleteItemsAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(item) > 0;
        }
        public async Task<bool> DeleteItemsByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(primaryKey) > 0;
        }
        public async ValueTask DisposeAsync() => await _connection.CloseAsync();

        public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>(Expression<Func<TTable, bool>> predicate) where TTable : class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.Where(predicate).ToListAsync();
        }
    }
}
