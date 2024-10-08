using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IMaintenanceRepository
    {
        Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync();
        Task<Maintenance> GetMaintenanceByIdAsync(int id);
        Task CreateMaintenanceAsync(Maintenance maintenance);
        Task UpdateMaintenanceAsync(Maintenance maintenance);
        Task SoftDeleteMaintenanceAsync(int id);
    }
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly MuseumDbContext _context;

        public MaintenanceRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateMaintenanceAsync(Maintenance maintenance)
        {
            if (maintenance == null)
                throw new ArgumentNullException(nameof(maintenance));

            // Agregar el objeto al contexto
            _context.maintenance.Add(maintenance);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync()
        {
            return await _context.maintenance
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Maintenance> GetMaintenanceByIdAsync(int id)
        {
            return await _context.maintenance
            .FirstOrDefaultAsync(s => s.maintenanceId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteMaintenanceAsync(int id)
        {
            var maintenance = await _context.maintenance.FindAsync(id);
            if (maintenance != null)
            {
                maintenance.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateMaintenanceAsync(Maintenance maintenance)
        {
            if (maintenance == null)
                throw new ArgumentNullException(nameof(maintenance));

            var existingMaintenance = await _context.maintenance.FindAsync(maintenance.maintenanceId);
            if (existingMaintenance == null)
                throw new ArgumentException($"maintenance with ID {maintenance.maintenanceId} not found");

            // Actualizar las propiedades del objeto existente
            existingMaintenance.artObject_Id = maintenance.artObject_Id;
            existingMaintenance.starDate = maintenance.starDate;
            existingMaintenance.endDate = maintenance.endDate;
            existingMaintenance.description = maintenance.description;
            existingMaintenance.cost = maintenance.cost;

            await _context.SaveChangesAsync();
        }
    }
}
