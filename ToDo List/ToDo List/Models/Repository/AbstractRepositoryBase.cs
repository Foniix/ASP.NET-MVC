using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo_List.Models.Database;

namespace ToDo_List.Models.Repository
{
    public abstract class AbstractRepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext _db;
        public AbstractRepositoryBase(DatabaseContext db)
        {
            _db = db;
        }
        public async Task Delete(int id)
        {
            T item = await Get(id);
            _db.Attach(item).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await GetTable().ToListAsync();
        }

        public async Task Save(T item)
        {
            _db.Attach(item).State = EntityState.Added;
            await _db.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            _db.Attach(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public abstract Task<T> Get(int id);
        public abstract DbSet<T> GetTable();
    }
}
