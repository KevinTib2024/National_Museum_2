using Microsoft.EntityFrameworkCore;
using National_Museum_2.Model;

namespace National_Museum_2.Context
{
    public class MuseumDbContext : DbContext
    {
        public MuseumDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.userId);

             modelBuilder.Entity<PermissionXUserType>()
                 .HasKey(u => u.permissionXUserTypeId);

             modelBuilder.Entity<Permissions>()
                 .HasKey(u => u.permissionsId);
   
            modelBuilder.Entity<Contact>()
                   .HasKey(c => c.contactId);


        }

        public DbSet<User> user { get; set; }
        public DbSet<UserType> userType { get; set; }
        public DbSet<PermissionXUserType> permissionXUserType { get; set; }
        public DbSet<Permissions> permissions { get; set; }
        public DbSet<IdentificationType> identificationType { get; set; }
        public DbSet<Gender> gender { get; set; }
        public DbSet<Contact> contact { get; set; }


    }
}   
