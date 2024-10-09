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

            //Tibaquichá
            modelBuilder.Entity<User>()
                .HasKey(u => u.userId);

             modelBuilder.Entity<PermissionXUserType>()
                 .HasKey(u => u.permissionXUserTypeId);

             modelBuilder.Entity<Permissions>()
                 .HasKey(u => u.permissionsId);
          
            modelBuilder.Entity<Contact>()
                   .HasKey(c => c.contactId);

            modelBuilder.Entity<UserType>()
                 .HasKey(u => u.userTypeId);

            modelBuilder.Entity<Gender>()
                .HasKey(u => u.genderId);

            modelBuilder.Entity<IdentificationType>()
                   .HasKey(c => c.identificationTypeId);

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

            modelBuilder.Entity<Games>()
                   .HasKey(c => c.gameId);

            modelBuilder.Entity<HistoricTickets>()
                   .HasKey(c => c.historicTicketId);

            modelBuilder.Entity<HistoricMaintenance>()
                   .HasKey(c => c.historicMaintenanceId);

            modelBuilder.Entity<HistoricUser>()
                   .HasKey(c => c.historicUserId);

            //Kevin
            modelBuilder.Entity<ArtRoom>()
                   .HasKey(c => c.artRoomId);

            modelBuilder.Entity<Location>()
                   .HasKey(c => c.locationId);

            modelBuilder.Entity<Exhibition>()
                   .HasKey(c => c.exhibitionId);

            modelBuilder.Entity<ArtObject>()
                   .HasKey(c => c.artObjectId);

            modelBuilder.Entity<Category>()
                   .HasKey(c => c.categoryId);

            modelBuilder.Entity<State>()
                   .HasKey(c => c.stateId);

            modelBuilder.Entity<Scenary>()
                   .HasKey(c => c.scenaryId);

            //Lucia
            modelBuilder.Entity<Tickets>()
                   .HasKey(c => c.ticketId);

            modelBuilder.Entity<TicketXCollection>()
                   .HasKey(c => c.ticketXCollectionId);

            modelBuilder.Entity<TicketType>()
                   .HasKey(c => c.ticketTypeId);

            modelBuilder.Entity<PaymentMethod>()
                   .HasKey(c => c.paymentMethodId);

            modelBuilder.Entity<GameProgress>()
                   .HasKey(c => c.gameProgressId);

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
