using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Repository
{
    public interface IMaintenanceRepository
    {
        Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync();
        Task<Maintenance> GetMaintenanceByAsync(int id);
        Task CreateMaintenanceAsync(Maintenance maintenance);
        Task UpdateMaintenanceAsync(Maintenance maintenance);
        Task SoftDeleteMaintenanceAsync(int id);
    }
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly MuseumDbContext _context;

        public MaintenanceRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateMaintenanceAsync(Maintenance maintenance)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Maintenance> GetMaintenanceByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteMaintenanceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMaintenanceAsync(Maintenance maintenance)
        {
            throw new NotImplementedException();
        }
    }
}
