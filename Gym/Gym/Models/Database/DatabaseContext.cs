using System.Data.Entity;

namespace Gym.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Hall> Halls { get; set; }
    }
}