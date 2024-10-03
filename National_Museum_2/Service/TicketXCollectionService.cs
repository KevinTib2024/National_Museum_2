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

        public Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TicketXCollection> GetTicketXCollectionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTicketXCollectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            throw new NotImplementedException();
        }
    }
}
