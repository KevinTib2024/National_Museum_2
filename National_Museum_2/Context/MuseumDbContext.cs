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
            /*
             modelBuilder.Entity<UserType>()
               .HasKey(u => u.userType);

             modelBuilder.Entity<Gender>()
               .HasKey(u => u.genderId);

            */  
            modelBuilder.Entity<Contact>()
                   .HasKey(c => c.contactId);

            // modelBuilder.Entity<IdentificationType>()
              //    .HasKey(c => c.identificationTypeId);
            /*

             // Relación uno a muchos entre User y Contact
             modelBuilder.Entity<Contact>()
                 .HasOne(c => c.User)
                 .WithMany(u => u.Contacts)
                 .HasForeignKey(c => c.userId);  // Clave foránea en Contac*/
        }

        public DbSet<User> user { get; set; }
        public DbSet<UserType> userType { get; set; }
        public DbSet<UserType> permissionXUserType { get; set; }
        public DbSet<UserType> permissions { get; set; }
        public DbSet<UserType> identificationType { get; set; }
        public DbSet<UserType> gender { get; set; }
        public DbSet<UserType> contact { get; set; }


    }
}   
