using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IHistoricUserService
    {
        Task<IEnumerable<HistoricUser>> GetAllHistoricUserAsync();
        Task<HistoricUser> GetHistoricUserByIdAsync(int id);
        Task CreateHistoricUserAsync(HistoricUser historicUser);
        Task UpdateHistoricUserAsync(HistoricUser historicUser);
        Task SoftDeleteHistoricUserAsync(int id);
    }

    public class HistoricUserService : IHistoricUserService
    {
        private readonly IHistoricUserRepository _historicUserRepository;

        public HistoricUserService(IHistoricUserRepository historicUserRepository)
        {
            _historicUserRepository = historicUserRepository;
        }

        public async Task CreateHistoricUserAsync(HistoricUser historicUser)
        {
            await _historicUserRepository.CreateHistoricUserAsync(historicUser);
        }

        public async Task<IEnumerable<HistoricUser>> GetAllHistoricUserAsync()
        {
            return await _historicUserRepository.GetAllHistoricUserAsync();
        }

        public async Task<HistoricUser> GetHistoricUserByIdAsync(int id)
        {
            return await _historicUserRepository.GetHistoricUserByIdAsync(id);
        }

        public async Task SoftDeleteHistoricUserAsync(int id)
        {
            await _historicUserRepository.SoftDeleteHistoricUserAsync(id);
        }

        public async Task UpdateHistoricUserAsync(HistoricUser historicUser)
        {
            await _historicUserRepository.UpdateHistoricUserAsync(historicUser);
        }
    }
}
