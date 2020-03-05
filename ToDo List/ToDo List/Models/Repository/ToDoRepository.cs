using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ToDo_List.Models.Database;

namespace ToDo_List.Models.Repository
{
    public class ToDoRepository : AbstractRepositoryBase<ToDo>
    {
        private readonly DatabaseContext _db;
        public ToDoRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<ToDo> Get(int id)
        {
            return await _db.ToDoList.FirstOrDefaultAsync(c => c.Id == id);
        }

        public override DbSet<ToDo> GetTable()
        {
            return _db.ToDoList;
        }
    }
}
