using Assignment_1_.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1_.DataAccess
{
    public class AdultsDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Job> Joblist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AdultDB.db");
        }
    }
}