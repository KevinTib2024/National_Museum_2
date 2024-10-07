using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITicketXCollectionRepository
    {
        Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync();
        Task<TicketXCollection> GetTicketXCollectionByIdAsync(int id);
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

        public async Task CreateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            if (ticketXCollection == null)
                throw new ArgumentNullException(nameof(ticketXCollection));

            // Agregar el objeto al contexto
            _context.ticketXCollection.Add(ticketXCollection);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TicketXCollection>> GetAllTicketXCollectionAsync()
        {
            return await _context.ticketXCollection
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<TicketXCollection> GetTicketXCollectionByIdAsync(int id)
        {
            return await _context.ticketXCollection
            .FirstOrDefaultAsync(s => s.ticketXCollectionId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteTicketXCollectionAsync(int id)
        {
            var ticketXCollection = await _context.ticketXCollection.FindAsync(id);
            if (ticketXCollection != null)
            {
                ticketXCollection.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTicketXCollectionAsync(TicketXCollection ticketXCollection)
        {
            if (ticketXCollection == null)
                throw new ArgumentNullException(nameof(ticketXCollection));

            var existingTicketXCollection = await _context.ticketXCollection.FindAsync(ticketXCollection.ticketXCollectionId);
            if (existingTicketXCollection == null)
                throw new ArgumentException($"ticketXCollection with ID {ticketXCollection.ticketXCollectionId} not found");

            // Actualizar las propiedades del objeto existente
            existingTicketXCollection.Ticket_Id = ticketXCollection.Ticket_Id;
            existingTicketXCollection.collection_Id = ticketXCollection.collection_Id;

            await _context.SaveChangesAsync();
        }
    }
}
