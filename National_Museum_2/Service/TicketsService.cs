using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITicketsService
    {
        Task<IEnumerable<Tickets>> GetAllTicketsAsync();
        Task<Tickets> GetTicketsByIdAsync(int id);
        Task CreateTicketsAsync(Tickets tickets);
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

        public Task CreateTicketsAsync(Tickets tickets)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tickets>> GetAllTicketsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tickets> GetTicketsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTicketsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketsAsync(Tickets tickets)
        {
            throw new NotImplementedException();
        }
    }
}
