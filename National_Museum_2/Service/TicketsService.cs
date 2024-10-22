using National_Museum_2.DTO.Tickets;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITicketsService
    {
        Task<IEnumerable<Tickets>> GetAllTicketsAsync();
        Task<Tickets> GetTicketsByIdAsync(int id);
        Task CreateTicketsAsync(CreateTicketsRequest tickets);
        Task UpdateTicketsAsync(Tickets tickets);
        Task SoftDeleteTicketsAsync(int id);
    }

    public class TicketsService : ITicketsService
    {
        private readonly ITicketsRepository _ticketsRepository;

        public TicketsService(ITicketsRepository ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }

        public async Task CreateTicketsAsync(CreateTicketsRequest tickets)
        {
            await _ticketsRepository.CreateTicketsAsync(tickets);
        }

        public async Task<IEnumerable<Tickets>> GetAllTicketsAsync()
        {
            return await _ticketsRepository.GetAllTicketsAsync();
        }

        public async Task<Tickets> GetTicketsByIdAsync(int id)
        {
            return await _ticketsRepository.GetTicketsByIdAsync(id);
        }

        public async Task SoftDeleteTicketsAsync(int id)
        {
            await _ticketsRepository.SoftDeleteTicketsAsync(id);
        }

        public async Task UpdateTicketsAsync(Tickets tickets)
        {
            await _ticketsRepository.UpdateTicketsAsync(tickets);
        }
    }
}
