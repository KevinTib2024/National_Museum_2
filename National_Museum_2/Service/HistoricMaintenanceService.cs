using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IHistoricMaintenanceService
    {
        Task<IEnumerable<HistoricMaintenance>> GetAllHistoricMaintenanceAsync();
        Task<HistoricMaintenance> GetHistoricMaintenanceByIdAsync(int id);
        Task CreateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance);
        Task UpdateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance);
        Task SoftDeleteHistoricMaintenanceAsync(int id);
    }

    public class HistoricMaintenanceService : IHistoricMaintenanceService
    {
        private readonly IHistoricMaintenanceRepository _historicMaintenanceRepository;

        public HistoricMaintenanceService(IHistoricMaintenanceRepository historicMaintenanceRepository)
        {
            _historicMaintenanceRepository = historicMaintenanceRepository;
        }

        public async Task CreateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance)
        {
            await _historicMaintenanceRepository.CreateHistoricMaintenanceAsync(historicMaintenance);
        }

        public async Task<IEnumerable<HistoricMaintenance>> GetAllHistoricMaintenanceAsync()
        {
            return await _historicMaintenanceRepository.GetAllHistoricMaintenanceAsync();
        }

        public async Task<HistoricMaintenance> GetHistoricMaintenanceByIdAsync(int id)
        {
            return await _historicMaintenanceRepository.GetHistoricMaintenanceByIdAsync(id);
        }

        public async Task SoftDeleteHistoricMaintenanceAsync(int id)
        {
            await _historicMaintenanceRepository.SoftDeleteHistoricMaintenanceAsync(id);
        }

        public async Task UpdateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance)
        {
            await _historicMaintenanceRepository.UpdateHistoricMaintenanceAsync(historicMaintenance);
        }
    }
}
