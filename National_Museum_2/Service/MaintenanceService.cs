using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IMaintenanceService
    {
        Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync();
        Task<Maintenance> GetMaintenanceByIdAsync(int id);
        Task CreateMaintenanceAsync(Maintenance maintenance);
        Task UpdateMaintenanceAsync(Maintenance maintenance);
        Task SoftDeleteMaintenanceAsync(int id);
    }

    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public Task CreateMaintenanceAsync(Maintenance maintenance)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Maintenance> GetMaintenanceByIdAsync(int id)
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
