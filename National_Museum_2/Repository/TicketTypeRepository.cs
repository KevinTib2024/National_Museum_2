using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.TicketType;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITicketTypeRepository
    {
        Task<IEnumerable<TicketType>> GetAllTicketTypeAsync();
        Task<TicketType> GetTicketTypeByIdAsync(int id);
        Task CreateTicketTypeAsync(CreateTicketTypeRequest ticketType);
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

        public async Task CreateTicketTypeAsync(CreateTicketTypeRequest ticketType)
        {
            if (ticketType == null)
                throw new ArgumentNullException(nameof(ticketType));
            var _newticketType = new TicketType
            {
                ticketType = ticketType.ticketType,
                price = ticketType.price,
            };

            // Agregar el objeto al contexto
            _context.ticketType.Add(_newticketType);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TicketType>> GetAllTicketTypeAsync()
        {
            return await _context.ticketType
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<TicketType> GetTicketTypeByIdAsync(int id)
        {
            return await _context.ticketType
            .FirstOrDefaultAsync(s => s.ticketTypeId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteTicketTypeAsync(int id)
        {
            var ticketType = await _context.ticketType.FindAsync(id);
            if (ticketType != null)
            {
                ticketType.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTicketTypeAsync(TicketType ticketType)
        {
            if (ticketType == null)
                throw new ArgumentNullException(nameof(ticketType));

            var existingTicketType = await _context.ticketType.FindAsync(ticketType.ticketTypeId);
            if (existingTicketType == null)
                throw new ArgumentException($"ticketType with ID {ticketType.ticketTypeId} not found");

            // Actualizar las propiedades del objeto existente
            existingTicketType.ticketType = ticketType.ticketType;
            existingTicketType.price = ticketType.price;

            await _context.SaveChangesAsync();
        }
    }
}
