using DeskShiraz.Models;
using Microsoft.EntityFrameworkCore;

namespace DeskShiraz.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
