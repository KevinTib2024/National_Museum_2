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

        public async Task CreateMaintenanceAsync(Maintenance maintenance)
        {
            await _maintenanceRepository.CreateMaintenanceAsync(maintenance);
        }

        public async Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync()
        {
            return await _maintenanceRepository.GetAllMaintenanceAsync();
        }

        public async Task<Maintenance> GetMaintenanceByIdAsync(int id)
        {
            return await _maintenanceRepository.GetMaintenanceByIdAsync(id);
        }

        public async Task SoftDeleteMaintenanceAsync(int id)
        {
            await _maintenanceRepository.SoftDeleteMaintenanceAsync(id);
        }

        public async Task UpdateMaintenanceAsync(Maintenance maintenance)
        {
            await _maintenanceRepository.UpdateMaintenanceAsync(maintenance);
        }
    }
}
