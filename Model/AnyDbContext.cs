using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Asp_Identity.Model
{
    public class AnyDbContext : IdentityDbContext
    {
        public AnyDbContext(DbContextOptions<AnyDbContext> options):base(options)
        {

        }
    }
}
