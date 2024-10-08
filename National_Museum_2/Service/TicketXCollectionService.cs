using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITicketXCollectionService
    {
        Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync();
        Task<TicketXCollection> GetTicketXCollectionByIdAsync(int id);
        Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection);
        Task UpdateTicketXCollectionAsync(TicketXCollection ticketXCollection);
        Task SoftDeleteTicketXCollectionAsync(int id);
    }

    public class TicketXCollectionService : ITicketXCollectionService
    {
        private readonly ITicketXCollectionRepository _ticketXCollectionRepository;

        public TicketXCollectionService(ITicketXCollectionRepository ticketXCollectionRepository)
        {
            _ticketXCollectionRepository = ticketXCollectionRepository;
        }

        public async Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            await _ticketXCollectionRepository.CreateTicketXCollectionAsync(ticketXCollection);
        }

        public async Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync()
        {
            return await _ticketXCollectionRepository.GetAllTicketXCollectionAsync();
        }

        public async Task<TicketXCollection> GetTicketXCollectionByIdAsync(int id)
        {
            return await _ticketXCollectionRepository.GetTicketXCollectionByIdAsync(id);
        }

        public async Task SoftDeleteTicketXCollectionAsync(int id)
        {
            await _ticketXCollectionRepository.SoftDeleteTicketXCollectionAsync(id);
        }

        public async Task UpdateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            await _ticketXCollectionRepository.UpdateTicketXCollectionAsync(ticketXCollection);
        }
    }
}
