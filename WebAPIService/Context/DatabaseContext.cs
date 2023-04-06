using Microsoft.EntityFrameworkCore;

namespace WebAPIService.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

    }
}
