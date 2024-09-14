using Microsoft.EntityFrameworkCore;
using National_Museum_2.Model;

namespace National_Museum_2.Context
{
    public class MuseoDbContext : DbContext
    {
        public MuseoDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<User> users { get; set; }

    }
}
