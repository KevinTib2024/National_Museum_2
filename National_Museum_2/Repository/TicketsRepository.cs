using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITicketsRepository
    {
        Task<IEnumerable<Tickets>> GetAllTicketsAsync();
        Task<Tickets> GetTicketsByIdAsync(int id);
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

        public async Task CreateTicketsAsync(Tickets tickets)
        {
            if (tickets == null)
                throw new ArgumentNullException(nameof(tickets));

            // Agregar el objeto al contexto
            _context.ticket.Add(tickets);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tickets>> GetAllTicketsAsync()
        {
            return await _context.ticket
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Tickets> GetTicketsByIdAsync(int id)
        {
            return await _context.ticket
            .FirstOrDefaultAsync(s => s.ticketId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteTicketsAsync(int id)
        {
            var tickets = await _context.ticket.FindAsync(id);
            if (tickets != null)
            {
                tickets.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTicketsAsync(Tickets tickets)
        {
            if (tickets == null)
                throw new ArgumentNullException(nameof(tickets));

            var existingTickets = await _context.ticket.FindAsync(tickets.ticketId);
            if (existingTickets == null)
                throw new ArgumentException($"tickets with ID {tickets.ticketId} not found");

            // Actualizar las propiedades del objeto existente
            existingTickets.user_Id = tickets.user_Id;
            existingTickets.visitDate = tickets.visitDate;
            existingTickets.ticketType_Id = tickets.ticketType_Id;
            existingTickets.paymentMethod_Id = tickets.paymentMethod_Id;
            existingTickets.employeeId = tickets.employeeId;
            existingTickets.ticketXCollection_Id = tickets.ticketXCollection_Id;

            await _context.SaveChangesAsync();
        }
    }
}
