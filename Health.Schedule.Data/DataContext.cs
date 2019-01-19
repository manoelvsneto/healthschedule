using Health.Schedule.Shared;
using Microsoft.EntityFrameworkCore;

namespace Health.Schedule.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
        public DbSet<User> Users { get; set; }
    }
}
