using Microsoft.EntityFrameworkCore;

namespace Sample
{
    public class CdsContext : DbContext
    {
        public CdsContext(DbContextOptions<CdsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
