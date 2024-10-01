using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface ITicketXCollectionRepository
    {
        Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync();
        Task<TicketXCollection> GetTicketXCollectionByAsync(int id);
        Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection);
        Task UpdateTicketXCollectionAsync(TicketXCollection ticketXCollection);
        Task SoftDeleteTicketXCollectionAsync(int id);
    }
    public class TicketXCollectionRepository : ITicketXCollectionRepository
    {
        private readonly MuseumDbContext _context;

        public TicketXCollectionRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TicketXCollection> GetTicketXCollectionByAsync(int id)
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