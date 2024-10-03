using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITicketTypeService
    {
        Task<IEnumerable<TicketType>> GetAllTicketTypeAsync();
        Task<TicketType> GetTicketTypeByIdAsync(int id);
        Task CreateTicketTypeAsync(TicketType ticketType);
        Task UpdateTicketTypeAsync(TicketType ticketType);
        Task SoftDeleteTicketTypeAsync(int id);
    }

    public class TicketTypeService : ITicketTypeService
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;

        public TicketTypeService(ITicketTypeRepository ticketTypeRepository)
        {
            _ticketTypeRepository = ticketTypeRepository;
        }

        public Task CreateTicketTypeAsync(TicketType ticketType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketType>> GetAllTicketTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TicketType> GetTicketTypeByIdAsync(int id)
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
