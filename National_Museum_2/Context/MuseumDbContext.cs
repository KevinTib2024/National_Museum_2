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
                .HasKey(u => u.Id);

           /* modelBuilder.Entity<UserType>()
            .HasKey(u => u.UserType_Id);

            modelBuilder.Entity<PermissionXUserType>()
            .HasKey(u => u.Permission_Id);

            modelBuilder.Entity<Permissions>()
            .HasKey(u => u.Permission_Id);

            modelBuilder.Entity<IdentificationType>()
            .HasKey(u => u.Identification_Type_Id);

            modelBuilder.Entity<Gender>()
            .HasKey(u => u.Gerder_Id);

            modelBuilder.Entity<Contact>()
            .HasKey(u => u.Contact_Id);*/
        }
        public DbSet<User> user { get; set; }
        /*public DbSet<UserType> userType { get; set; }
        public DbSet<UserType> permissionXUserType { get; set; }
        public DbSet<UserType> permissions { get; set; }
        public DbSet<UserType> identificationType { get; set; }
        public DbSet<UserType> gender { get; set; }
        public DbSet<UserType> contact { get; set; }*/

        public DbSet<ArtObject> artObjects { get; set; 
            /*
        public DbSet<ArtRoom> artRooms{ get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Exhibition> exhibition { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<State> states{ get; set; }*/





    }
}
