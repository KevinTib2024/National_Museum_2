using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IHistoricTicketsRepository
    {
        Task<IEnumerable<HistoricTickets>> GetAllHistoricTicketsAsync();
        Task<HistoricTickets> GetHistoricTicketsByIdAsync(int id);
        Task CreateHistoricTicketsAsync(HistoricTickets historicTickets);
        Task UpdateHistoricTicketsAsync(HistoricTickets historicTickets);
        Task SoftDeleteHistoricTicketsAsync(int id);
    }

    public class HistoricTicketsRepository : IHistoricTicketsRepository
    {
        private readonly MuseumDbContext _context;

        public HistoricTicketsRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateHistoricTicketsAsync(HistoricTickets historicTickets)
        {
            if (historicTickets == null)
                throw new ArgumentNullException(nameof(historicTickets));

            // Agregar el objeto al contexto
            _context.historicTickets.Add(historicTickets);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HistoricTickets>> GetAllHistoricTicketsAsync()
        {
            return await _context.historicTickets
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<HistoricTickets> GetHistoricTicketsByIdAsync(int id)
        {
            return await _context.historicTickets
            .FirstOrDefaultAsync(s => s.historicTicketId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteHistoricTicketsAsync(int id)
        {
            var historicTickets = await _context.historicTickets.FindAsync(id);
            if (historicTickets != null)
            {
                historicTickets.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateHistoricTicketsAsync(HistoricTickets historicTickets)
        {
            if (historicTickets == null)
                throw new ArgumentNullException(nameof(historicTickets));

            var existingHistoricTickets = await _context.historicTickets.FindAsync(historicTickets.historicTicketId);
            if (existingHistoricTickets == null)
                throw new ArgumentException($"historicTickets with ID {historicTickets.historicTicketId} not found");

            // Actualizar las propiedades del objeto existente
            existingHistoricTickets.ticket_Id = historicTickets.ticket_Id;
            existingHistoricTickets.user_Id = historicTickets.user_Id;
            existingHistoricTickets.visitDate = historicTickets.visitDate;
            existingHistoricTickets.ticketType_Id = historicTickets.ticketType_Id;
            existingHistoricTickets.paymentMethod_Id = historicTickets.paymentMethod_Id;
            existingHistoricTickets.employeeId = historicTickets.employeeId;
            existingHistoricTickets.ticketXCollection_Id = historicTickets.ticketXCollection_Id;
            existingHistoricTickets.ModificationDate = historicTickets.ModificationDate;
            existingHistoricTickets.ModicationBy = historicTickets.ModicationBy;

            await _context.SaveChangesAsync();
        }
    }
}
