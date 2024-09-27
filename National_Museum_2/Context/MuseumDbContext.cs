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

            //Oscar
            modelBuilder.Entity<EmployeesXArtRoom>()
                   .HasKey(c => c.employeesXArtRoomId);

            modelBuilder.Entity<Collection>()
                   .HasKey(c => c.collectionId);

            modelBuilder.Entity<Employees>()
                   .HasKey(c => c.employeeId);

            modelBuilder.Entity<Maintenance>()
                   .HasKey(c => c.maintenanceId);

            modelBuilder.Entity<TypeEmployee>()
                   .HasKey(c => c.typeEmployeeId);

            modelBuilder.Entity<WorkShedule>()
                   .HasKey(c => c.workSheduleId);
        }

        public DbSet<User> user { get; set; }
        public DbSet<UserType> userType { get; set; }
        public DbSet<UserType> permissionXUserType { get; set; }
        public DbSet<UserType> permissions { get; set; }
        public DbSet<UserType> identificationType { get; set; }
        public DbSet<UserType> gender { get; set; }
        public DbSet<UserType> contact { get; set; }

        //Oscar
        public DbSet<Collection> collection { get; set; }
        public DbSet<EmployeesXArtRoom> employeesXArtRoom { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Maintenance> maintenances { get; set; }
        public DbSet<TypeEmployee> typeEmployee { get; set; }
        public DbSet<WorkShedule> workShedule { get; set; }
    }
}   
