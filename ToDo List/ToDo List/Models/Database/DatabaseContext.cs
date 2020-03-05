using Microsoft.EntityFrameworkCore;

namespace ToDo_List.Models.Database
{
    public sealed class DatabaseContext : DbContext
    {
        public DbSet<ToDo> ToDoList { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
            //Create DB if not exist
            Database.EnsureCreated();
        }
    }
}
