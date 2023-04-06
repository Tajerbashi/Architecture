using Microsoft.EntityFrameworkCore;

namespace RoshdGroup.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

    }
}
