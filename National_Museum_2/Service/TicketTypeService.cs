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

        public async Task CreateTicketTypeAsync(TicketType ticketType)
        {
            await _ticketTypeRepository.CreateTicketTypeAsync(ticketType);
        }

        public async Task<IEnumerable<TicketType>> GetAllTicketTypeAsync()
        {
            return await _ticketTypeRepository.GetAllTicketTypeAsync();
        }

        public async Task<TicketType> GetTicketTypeByIdAsync(int id)
        {
            return await _ticketTypeRepository.GetTicketTypeByIdAsync(id);
        }

        public async Task SoftDeleteTicketTypeAsync(int id)
        {
            await _ticketTypeRepository.SoftDeleteTicketTypeAsync(id);
        }

        public async Task UpdateTicketTypeAsync(TicketType ticketType)
        {
            await _ticketTypeRepository.UpdateTicketTypeAsync(ticketType);
        }
    }
}
