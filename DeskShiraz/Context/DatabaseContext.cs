using DeskShiraz.Models;
using Microsoft.EntityFrameworkCore;

namespace DeskShiraz.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
