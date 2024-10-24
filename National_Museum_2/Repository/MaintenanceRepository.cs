using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Maintenance;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IMaintenanceRepository
    {
        Task<IEnumerable<Maintenance>> GetAllMaintenanceAsync();
        Task<Maintenance> GetMaintenanceByIdAsync(int id);
        Task CreateMaintenanceAsync(CreateMaintenanceRequest maintenance);
        Task UpdateMaintenanceAsync(UpdateMaintenanceRequest maintenance);
        Task SoftDeleteMaintenanceAsync(int id);
    }
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly MuseumDbContext _context;

        public MaintenanceRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateMaintenanceAsync(CreateMaintenanceRequest maintenance)
        {
            var _artObject_Id = await _context.artObject.FindAsync(maintenance.artObject_Id);
            if (maintenance == null)
                throw new ArgumentNullException(nameof(maintenance));

            if (_artObject_Id == null)
            {
                throw new Exception("No se encontro id de la obra");
            }
            var _newmaintenance = new Maintenance
            {
                artObject_Id = maintenance.artObject_Id,
                starDate = maintenance.starDate,
                endDate = maintenance.endDate,
                description = maintenance.description,
                cost = maintenance.cost,
            };
                // Agregar el objeto al contexto
                _context.maintenance.Add(_newmaintenance);

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

        public async Task UpdateMaintenanceAsync(UpdateMaintenanceRequest maintenance)
        {
            if (maintenance == null)
                throw new ArgumentNullException(nameof(maintenance));

            var existingMaintenance = await _context.maintenance.FindAsync(maintenance.maintenanceId);
            if (existingMaintenance == null)
                throw new ArgumentException($"maintenance with ID {maintenance.maintenanceId} not found");

            // Actualizar las propiedades del objeto existente
            existingMaintenance.artObject_Id = maintenance.artObject_Id?? existingMaintenance.artObject_Id;
            existingMaintenance.starDate = maintenance.starDate?? existingMaintenance.starDate;
            existingMaintenance.endDate = maintenance.endDate?? existingMaintenance.endDate;
            existingMaintenance.description = String.IsNullOrEmpty(maintenance.description)? existingMaintenance.description : maintenance.description;
            existingMaintenance.cost = maintenance.cost ?? existingMaintenance.cost;

            await _context.SaveChangesAsync();
        }
    }
}
