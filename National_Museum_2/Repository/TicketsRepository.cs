using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Tickets;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITicketsRepository
    {
        Task<IEnumerable<Tickets>> GetAllTicketsAsync();
        Task<Tickets> GetTicketsByIdAsync(int id);
        Task CreateTicketsAsync(CreateTicketsRequest tickets);
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

        public async Task CreateTicketsAsync(CreateTicketsRequest tickets)
        {
            var _user_Id = await _context.user.FindAsync(tickets.user_Id);
            var _ticketType_Id = await _context.ticketType.FindAsync(tickets.ticketType_Id);
            var _paymentMethod_Id = await _context.paymentMethods.FindAsync(tickets.paymentMethod_Id);
            var employeeId = await _context.employee.FindAsync(tickets.employeeId);

            if (tickets == null)
                throw new ArgumentNullException(nameof(tickets));

            if (_user_Id == null)
            {
                throw new Exception("No se encontro id del usuario");
            }
            if (_ticketType_Id == null)
            {
                throw new Exception("No se encontro el tipo de ticket");
            }
            if (_paymentMethod_Id == null)
            {
                throw new Exception("No se encontro el metodo de pago");
            }
            if (employeeId == null)
            {
                throw new Exception("No se encontro el id del empleado");
            }
            var _newtickets = new Tickets
            {
                user_Id = tickets.user_Id,
                ticketType_Id = tickets.ticketType_Id,
                paymentMethod_Id = tickets.paymentMethod_Id,
                employeeId = tickets.employeeId,
                visitDate = tickets.visitDate,
            };

            // Agregar el objeto al contexto
            _context.ticket.Add(_newtickets);

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
            await _context.SaveChangesAsync();
        }
    }
}
