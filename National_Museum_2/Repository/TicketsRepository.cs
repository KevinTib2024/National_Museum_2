using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITicketsRepository
    {
        Task<IEnumerable<Tickets>> GetAllTicketsAsync();
        Task<Tickets> GetTicketsByAsync(int id);
        Task CreateTicketsAsync(Tickets tickets);
        Task UpdateTicketsAsync(Tickets tickets);
        Task SoftDeleteTicketsAsync(int id);
    }

    public class TicketsRepository : ITicketsRepository
    {
        private readonly MuseumDbContext _context;

        public TicketsRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateTicketsAsync(Tickets tickets)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tickets>> GetAllTicketsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tickets> GetTicketsByAsync(int id)
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
