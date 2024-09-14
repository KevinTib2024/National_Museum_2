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

            /*modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<UserType>()
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


            modelBuilder.Entity<Employees>()
            .HasKey(u => u.Employee_Id);

            /*modelBuilder.Entity<EmployeesXArtRoom>()
            .HasKey(u => u.EmployeesXArtRoom_Id);

            modelBuilder.Entity<Collection>()
            .HasKey(u => u.Collection_Id);

            modelBuilder.Entity<Maintenance>()
            .HasKey(u => u.Maintenance_Id);

            modelBuilder.Entity<TypeEmployee>()
            .HasKey(u => u.TypeEmployee_Id);

            modelBuilder.Entity<WorkShedule>()
            .HasKey(u => u.WorkShedule_Id);*/
        }
        public DbSet<User> user { get; set; }
        /*public DbSet<UserType> userTypes { get; set; }
        public DbSet<PermissionXUserType> permissionXUserType { get; set; }
        public DbSet<Permissions> permissions { get; set; }
        public DbSet<IdentificationType> identificationType { get; set; }
        public DbSet<Gender> gender { get; set; }
        public DbSet<Contact> contact { get; set; }*/

        /*public DbSet<ArtObject> artObjects { get; set; }
        
        public DbSet<ArtRoom> artRooms{ get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Exhibition> exhibition { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<State> states{ get; set; }*/

        public DbSet<ArtRoom> artRooms{ get; set; }
        /*public DbSet<Category> category { get; set; }
        public DbSet<Exhibition> exhibition { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<State> states{ get; set; }*/

        public DbSet<Employees> employees { get; set; }
        /*public DbSet<EmployeesXArtRoom>  employeesXArtRooms{ get; set; }
        public DbSet<Collection> collections{ get; set; }
        public DbSet<Maintenance> maintenances { get; set; }
        public DbSet<TypeEmployee> typeEmployees { get; set; }
        public DbSet<WorkShedule> workShedules{ get; set; }*/
    }
}
