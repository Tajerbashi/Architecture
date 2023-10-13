using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web.API.Authentication
{
    public sealed class ApplicationDatabase : IdentityDbContext<AppUser>
    {
        public ApplicationDatabase(DbContextOptions options) : base(options) { }
    }
}
