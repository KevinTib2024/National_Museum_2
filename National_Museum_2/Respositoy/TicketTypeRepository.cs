using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface ITicketTypeRepository
    {
        Task<IEnumerable<TicketType>> GetAllTicketTypeAsync();
        Task<TicketType> GetTicketTypeByAsync(int id);
        Task CreateTicketTypeAsync(TicketType ticketType);
        Task UpdateTicketTypeAsync(TicketType ticketType);
        Task SoftDeleteTicketTypeAsync(int id);
    }
    public class TicketTypeRepository : ITicketTypeRepository
    {
        private readonly MuseumDbContext _context;

        public TicketTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateTicketTypeAsync(TicketType ticketType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketType>> GetAllTicketTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TicketType> GetTicketTypeByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTicketTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketTypeAsync(TicketType ticketType)
        {
            throw new NotImplementedException();
        }
    }   
}