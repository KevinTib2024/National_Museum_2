using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IHistoricMaintenanceRepository
    {
        Task<IEnumerable<HistoricMaintenance>> GetAllHistoricMaintenanceAsync();
        Task<HistoricMaintenance> GetHistoricMaintenanceByIdAsync(int id);
        Task CreateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance);
        Task UpdateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance);
        Task SoftDeleteHistoricMaintenanceAsync(int id);
    }

    public class HistoricMaintenanceRepository : IHistoricMaintenanceRepository
    {
        private readonly MuseumDbContext _context;

        public HistoricMaintenanceRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance)
        {
            if (historicMaintenance == null)
                throw new ArgumentNullException(nameof(historicMaintenance));

            // Agregar el objeto al contexto
            _context.historicMaintenance.Add(historicMaintenance);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HistoricMaintenance>> GetAllHistoricMaintenanceAsync()
        {
            return await _context.historicMaintenance
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<HistoricMaintenance> GetHistoricMaintenanceByIdAsync(int id)
        {
            return await _context.historicMaintenance
            .FirstOrDefaultAsync(s => s.historicMaintenanceId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteHistoricMaintenanceAsync(int id)
        {
            var historicMaintenance = await _context.historicMaintenance.FindAsync(id);
            if (historicMaintenance != null)
            {
                historicMaintenance.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateHistoricMaintenanceAsync(HistoricMaintenance historicMaintenance)
        {
            if (historicMaintenance == null)
                throw new ArgumentNullException(nameof(historicMaintenance));

            var existingHistoricMaintenance = await _context.historicMaintenance.FindAsync(historicMaintenance.historicMaintenanceId);
            if (existingHistoricMaintenance == null)
                throw new ArgumentException($"historicMaintenance with ID {historicMaintenance.historicMaintenanceId} not found");

            // Actualizar las propiedades del objeto existente
            existingHistoricMaintenance.maintenance_Id = historicMaintenance.maintenance_Id;
            existingHistoricMaintenance.artObject_Id = historicMaintenance.artObject_Id;
            existingHistoricMaintenance.starDate = historicMaintenance.starDate;
            existingHistoricMaintenance.endDate = historicMaintenance.endDate;
            existingHistoricMaintenance.description = historicMaintenance.description;
            existingHistoricMaintenance.cost = historicMaintenance.cost;
            existingHistoricMaintenance.ModificationDate = historicMaintenance.ModificationDate;
            existingHistoricMaintenance.ModicationBy = historicMaintenance.ModicationBy;


            await _context.SaveChangesAsync();
        }
    }
}
