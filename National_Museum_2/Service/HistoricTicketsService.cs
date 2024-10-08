using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IHistoricTicketsService
    {
        Task<IEnumerable<HistoricTickets>> GetAllHistoricTicketsAsync();
        Task<HistoricTickets> GetHistoricTicketsByIdAsync(int id);
        Task CreateHistoricTicketsAsync(HistoricTickets historicTickets);
        Task UpdateHistoricTicketsAsync(HistoricTickets historicTickets);
        Task SoftDeleteHistoricTicketsAsync(int id);
    }

    public class HistoricTicketsService : IHistoricTicketsService
    {
        private readonly IHistoricTicketsRepository _historicTicketsRepository;

        public HistoricTicketsService(IHistoricTicketsRepository historicTicketsRepository)
        {
            _historicTicketsRepository = historicTicketsRepository;
        }

        public async Task CreateHistoricTicketsAsync(HistoricTickets historicTickets)
        {
            await _historicTicketsRepository.CreateHistoricTicketsAsync(historicTickets);
        }

        public async Task<IEnumerable<HistoricTickets>> GetAllHistoricTicketsAsync()
        {
            return await _historicTicketsRepository.GetAllHistoricTicketsAsync();
        }

        public async Task<HistoricTickets> GetHistoricTicketsByIdAsync(int id)
        {
            return await _historicTicketsRepository.GetHistoricTicketsByIdAsync(id);
        }

        public async Task SoftDeleteHistoricTicketsAsync(int id)
        {
            await _historicTicketsRepository.SoftDeleteHistoricTicketsAsync(id);
        }

        public async Task UpdateHistoricTicketsAsync(HistoricTickets historicTickets)
        {
            await _historicTicketsRepository.UpdateHistoricTicketsAsync(historicTickets);
        }
    }
}
