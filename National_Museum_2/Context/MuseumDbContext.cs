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

            //Users
            modelBuilder.Entity<User>().HasOne(u => u.user_Type).WithMany(t => t.users).HasForeignKey(u => u.user_Type_Id);
            modelBuilder.Entity<User>().HasOne(u => u.identificationType).WithMany(t => t.users).HasForeignKey(u => u.identificationType_Id);
            modelBuilder.Entity<User>().HasOne(u => u.gender).WithMany(t => t.users).HasForeignKey(u => u.gender_Id);
            modelBuilder.Entity<User>().HasKey(u => u.userId);
            //PermissionXUserType
            modelBuilder.Entity<PermissionXUserType>().HasOne(v => v.permissions).WithMany(t => t.permissionXUserTypes).HasForeignKey(v => v.permissionXUserTypeId);
            modelBuilder.Entity<PermissionXUserType>().HasOne(v => v.userType).WithMany(t => t.permissionsXUserType).HasForeignKey(t => t.userType_Id);
            modelBuilder.Entity<PermissionXUserType>()
                 .HasKey(u => u.permissionXUserTypeId);
            //Permissions
             modelBuilder.Entity<Permissions>()
                 .HasKey(u => u.permissionsId);
          //Contact
            modelBuilder.Entity<Contact>()
                   .HasKey(c => c.contactId);
            //UserType
            modelBuilder.Entity<UserType>()
                 .HasKey(u => u.userTypeId);
            //Gender
            modelBuilder.Entity<Gender>()
                .HasKey(u => u.genderId);
            //IdentificationType
            modelBuilder.Entity<IdentificationType>()
                   .HasKey(c => c.identificationTypeId);

            //EmployesXArtRoom
            modelBuilder.Entity<EmployeesXArtRoom>()
                   .HasKey(c => c.employeesXArtRoomId);
            //Collection
            modelBuilder.Entity<Collection>()
                   .HasKey(c => c.collectionId);
            //Employes
            modelBuilder.Entity<Employees>()
                   .HasKey(c => c.employeeId);
            //Maintance
            modelBuilder.Entity<Maintenance>()
                   .HasKey(c => c.maintenanceId);
            //TypeEmployee
            modelBuilder.Entity<TypeEmployee>()
                   .HasKey(c => c.typeEmployeeId);
            //WorkShedule
            modelBuilder.Entity<WorkShedule>()
                   .HasKey(c => c.workSheduleId);
            //Games
            modelBuilder.Entity<Games>()
                   .HasKey(c => c.gameId);
            //HistoricTickets
            modelBuilder.Entity<HistoricTickets>()
                   .HasKey(c => c.historicTicketId);
            //HistoricMaintenance
            modelBuilder.Entity<HistoricMaintenance>()
                   .HasKey(c => c.historicMaintenanceId);
            //HistoricUser
            modelBuilder.Entity<HistoricUser>()
                   .HasKey(c => c.historicUserId);

            //Kevin
            modelBuilder.Entity<ArtRoom>()
                   .HasKey(c => c.artRoomId);
            //Location
            modelBuilder.Entity<Location>()
                   .HasKey(c => c.locationId);
            //Exhibition
            modelBuilder.Entity<Exhibition>()
                   .HasKey(c => c.exhibitionId);
            //ArtObject
            modelBuilder.Entity<ArtObject>()
                   .HasKey(c => c.artObjectId);
            //Category
            modelBuilder.Entity<Category>()
                   .HasKey(c => c.categoryId);
            //State
            modelBuilder.Entity<State>()
                   .HasKey(c => c.stateId);
            //Scenary
            modelBuilder.Entity<Scenary>()
                   .HasKey(c => c.scenaryId);

            //Tickets
            modelBuilder.Entity<Tickets>()
                   .HasKey(c => c.ticketId);
            //TicketXCollection
            modelBuilder.Entity<TicketXCollection>()
                   .HasKey(c => c.ticketXCollectionId);
            //TicketType
            modelBuilder.Entity<TicketType>()
                   .HasKey(c => c.ticketTypeId);
            //PaymentMethod
            modelBuilder.Entity<PaymentMethod>()
                   .HasKey(c => c.paymentMethodId);
            //GameProgress
            modelBuilder.Entity<GameProgress>()
                   .HasKey(c => c.gameProgressId);
            //GameState
            modelBuilder.Entity<GameState>()
                   .HasKey(c => c.gameStateId);
        }

        //Tibaquichá
        public DbSet<User> user { get; set; }
        public DbSet<UserType> userType { get; set; }
        public DbSet<PermissionXUserType> permissionXUserType { get; set; }
        public DbSet<Permissions> permissions { get; set; }
        public DbSet<IdentificationType> identificationType { get; set; }
        public DbSet<Gender> gender { get; set; }
        public DbSet<Contact> contact { get; set; }

        //Oscar
        public DbSet<Collection> collection { get; set; }
        public DbSet<EmployeesXArtRoom> employeesXArtRoom { get; set; }
        public DbSet<Employees> employee { get; set; }
        public DbSet<Maintenance> maintenance { get; set; }
        public DbSet<TypeEmployee> typeEmployee { get; set; }
        public DbSet<WorkShedule> workShedule { get; set; }
        public DbSet<Games> games { get; set; }
        public DbSet<HistoricTickets> historicTickets { get; set; }
        public DbSet<HistoricMaintenance> historicMaintenance { get; set; }
        public DbSet<HistoricUser> historicUser { get; set; }

        //Kevin R
        public DbSet<ArtRoom> artRoom { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Exhibition> exhibition { get; set; }
        public DbSet<ArtObject> artObject{ get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<State> state { get; set; }

        public DbSet<Scenary> scenary { get; set; }

        //Lucia
        public DbSet<Tickets> ticket { get; set; }
        public DbSet<TicketXCollection> ticketXCollection { get; set; }
        public DbSet<TicketType> ticketType { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<GameProgress> gameProgresses { get; set; }
        public DbSet<GameState> gameStates { get; set; }
    }
}   
