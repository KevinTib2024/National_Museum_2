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
            modelBuilder.Entity<User>().HasOne(u => u.user_Type).WithMany(ut => ut.users).HasForeignKey(u => u.user_Type_Id);
            modelBuilder.Entity<User>().HasOne(u => u.identificationType).WithMany(it => it.users).HasForeignKey(u => u.identificationType_Id);
            modelBuilder.Entity<User>().HasOne(u => u.gender).WithMany(g => g.users).HasForeignKey(u => u.gender_Id);
            modelBuilder.Entity<User>().HasKey(u => u.userId);

            //PermissionXUserType
            modelBuilder.Entity<PermissionXUserType>().HasOne(pu => pu.permissions).WithMany(p => p.permissionXUserTypes).HasForeignKey(pu => pu.permissionXUserTypeId).OnDelete(DeleteBehavior.Restrict) ;
            modelBuilder.Entity<PermissionXUserType>().HasOne(pu => pu.userType).WithMany(ut => ut.permissionsXUserType).HasForeignKey(pu => pu.userType_Id).OnDelete(DeleteBehavior.Restrict) ;
            modelBuilder.Entity<PermissionXUserType>().HasKey(pu => pu.permissionXUserTypeId);

            //Permissions
            modelBuilder.Entity<Permissions>().HasKey(u => u.permissionsId);

            //Contact
            modelBuilder.Entity<Contact>().HasOne(c => c.user).WithMany(u => u.contacts).HasForeignKey(c => c.contactId);
            modelBuilder.Entity<Contact>().HasKey(c => c.contactId);

            //UserType
            modelBuilder.Entity<UserType>().HasKey(u => u.userTypeId);

            //Gender
            modelBuilder.Entity<Gender>().HasKey(u => u.genderId);

            //IdentificationType
            modelBuilder.Entity<IdentificationType>().HasKey(c => c.identificationTypeId);

            //EmployesXArtRoom
            modelBuilder.Entity<EmployeesXArtRoom>().HasOne(ea => ea.employee).WithMany(e => e.employeesXArtRooms).HasForeignKey(ea => ea.employeeId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeesXArtRoom>().HasOne(ea => ea.artRoom).WithMany(ar => ar.employeesXArtRoom).HasForeignKey(ea => ea.artRoomId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeesXArtRoom>().HasKey(c => c.employeesXArtRoomId);

            //Collection
            modelBuilder.Entity<Collection>().HasKey(c => c.collectionId);

            //Employes
            modelBuilder.Entity<Employees>().HasOne(e => e.typeEmployee).WithMany(te => te.employees).HasForeignKey(e => e.typeEmployee_Id);
            modelBuilder.Entity<Employees>().HasOne(e => e.workShedule).WithMany(ws => ws.employees).HasForeignKey(e => e.workShedule_Id);
            modelBuilder.Entity<Employees>().HasOne(e => e.user).WithMany(u => u.employees).HasForeignKey(e => e.user_Id);
            modelBuilder.Entity<Employees>().HasKey(c => c.employeeId);

            //Maintance
            modelBuilder.Entity<Maintenance>().HasOne(m => m.artObject).WithMany(at => at.maintenance).HasForeignKey(m => m.artObject_Id);
            modelBuilder.Entity<Maintenance>().HasKey(c => c.maintenanceId);


            //TypeEmployee
            modelBuilder.Entity<TypeEmployee>().HasKey(c => c.typeEmployeeId);

            //WorkShedule
            modelBuilder.Entity<WorkShedule>().HasKey(c => c.workSheduleId);

            //Games
            modelBuilder.Entity<Games>().HasOne(g => g.user).WithMany(u => u.games).HasForeignKey(g => g.user_Id);
            modelBuilder.Entity<Games>().HasOne(g => g.scenary).WithMany(u => u.games).HasForeignKey(g => g.scenary_Id);
            modelBuilder.Entity<Games>().HasOne(g => g.gameProgress).WithMany(u => u.games).HasForeignKey(g => g.gameProgress_Id);
            modelBuilder.Entity<Games>().HasOne(g => g.gameState).WithMany(u => u.games).HasForeignKey(g => g.gameState_Id);
            modelBuilder.Entity<Games>().HasKey(c => c.gameId);

            //HistoricTickets
            modelBuilder.Entity<HistoricTickets>().HasKey(c => c.historicTicketId);

            //HistoricMaintenance
            modelBuilder.Entity<HistoricMaintenance>().HasKey(c => c.historicMaintenanceId);

            //HistoricUser
            modelBuilder.Entity<HistoricUser>().HasKey(c => c.historicUserId);

            //ArtRoom
            modelBuilder.Entity<ArtRoom>().HasOne(ar => ar.location).WithMany(l => l.artRooms).HasForeignKey(ar => ar.location_Id);
            modelBuilder.Entity<ArtRoom>().HasOne(ar => ar.collection).WithMany(c => c.artRooms).HasForeignKey(ar => ar.collection_Id);
            modelBuilder.Entity<ArtRoom>().HasKey(c => c.artRoomId);

            //Location
            modelBuilder.Entity<Location>().HasKey(c => c.locationId);

            //Exhibition
            modelBuilder.Entity<Exhibition>().HasOne(e => e.artRoom).WithMany(ar => ar.exhibition).HasForeignKey(e => e.artRoom_Id);
            modelBuilder.Entity<Exhibition>().HasKey(c => c.exhibitionId);

            //ArtObject
            modelBuilder.Entity<ArtObject>().HasOne(ao => ao.category).WithMany(c => c.artObjects).HasForeignKey(ao => ao.category_Id);
            modelBuilder.Entity<ArtObject>().HasOne(ao => ao.exhibition).WithMany(e => e.artObjects).HasForeignKey(ao => ao.exhibition_Id);
            modelBuilder.Entity<ArtObject>().HasKey(c => c.artObjectId);

            //Category
            modelBuilder.Entity<Category>().HasKey(c => c.categoryId);

            //State
            modelBuilder.Entity<State>().HasKey(c => c.stateId);

            //Scenary
            modelBuilder.Entity<Scenary>()
                   .HasKey(c => c.scenaryId);

            //Tickets
            modelBuilder.Entity<Tickets>().HasOne(t => t.user).WithMany(u => u.tickets).HasForeignKey(t => t.ticketId);
            modelBuilder.Entity<Tickets>().HasOne(t => t.ticketType).WithMany(tt => tt.tickets).HasForeignKey(t => t.ticketType_Id);
            modelBuilder.Entity<Tickets>().HasOne(t => t.paymentMethod).WithMany(pm => pm.tickets).HasForeignKey(t => t.paymentMethod_Id);
            modelBuilder.Entity<Tickets>().HasKey(c => c.ticketId);

            //TicketXCollection
            modelBuilder.Entity<TicketXCollection>().HasOne(tc => tc.collection).WithMany(c => c.ticketXCollections).HasForeignKey(tc => tc.collection_Id).OnDelete(DeleteBehavior.Restrict) ;
            modelBuilder.Entity<TicketXCollection>().HasOne(tc => tc.Ticket).WithMany(c => c.ticketXCollections).HasForeignKey(tc => tc.Ticket_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TicketXCollection>().HasKey(c => c.ticketXCollectionId);

            //TicketType
            modelBuilder.Entity<TicketType>().HasKey(c => c.ticketTypeId);

            //PaymentMethod
            modelBuilder.Entity<PaymentMethod>().HasKey(c => c.paymentMethodId);

            //GameProgress
            modelBuilder.Entity<GameProgress>().HasKey(c => c.gameProgressId);

            //GameState
            modelBuilder.Entity<GameState>().HasKey(c => c.gameStateId);
            //MaintenanceXEmployee
            modelBuilder.Entity<MaintenanceXEmployee>().HasKey(m => m.maintenanceXEmployee_Id);
            modelBuilder.Entity<MaintenanceXEmployee>().HasOne(me => me.maitenance).WithMany(m => m.maintenanceXEmployees).HasForeignKey(me => me.maintenanceXEmployee_Id) ;
            modelBuilder.Entity<MaintenanceXEmployee>().HasOne(me => me.employees).WithMany(m => m.maintenanceXEmployee).HasForeignKey(me => me.employee_Id).OnDelete(DeleteBehavior.Restrict) ;

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

        public DbSet<MaintenanceXEmployee> maintenanceXEmployee { get; set; }
    }
}   
