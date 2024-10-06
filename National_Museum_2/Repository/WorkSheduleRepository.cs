using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IWorkSheduleRepository
    {
        Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync();
        Task<WorkShedule> GetWorkSheduleByIdAsync(int id);
        Task CreateWorkSheduleAsync(WorkShedule workShedule);
        Task UpdateWorkSheduleAsync(WorkShedule workShedule);
        Task SoftDeleteWorkSheduleAsync(int id);
    }

    public class WorkSheduleRepository : IWorkSheduleRepository
    {
        private readonly MuseumDbContext _context;

        public WorkSheduleRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateWorkSheduleAsync(WorkShedule workShedule)
        {
            if (workShedule == null)
                throw new ArgumentNullException(nameof(workShedule));

            // Agregar el objeto al contexto
            _context.workShedule.Add(workShedule);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync()
        {
            return await _context.workShedule
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<WorkShedule> GetWorkSheduleByIdAsync(int id)
        {
            return await _context.workShedule
            .FirstOrDefaultAsync(s => s.workSheduleId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteWorkSheduleAsync(int id)
        {
            var workShedule = await _context.workShedule.FindAsync(id);
            if (workShedule != null)
            {
                workShedule.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateWorkSheduleAsync(WorkShedule workShedule)
        {
            if (workShedule == null)
                throw new ArgumentNullException(nameof(workShedule));

            var existingWorkShedule = await _context.workShedule.FindAsync(workShedule.workSheduleId);
            if (existingWorkShedule == null)
                throw new ArgumentException($"workShedule with ID {workShedule.workSheduleId} not found");

            // Actualizar las propiedades del objeto existente
            existingWorkShedule.workShedule = workShedule.workShedule;

            await _context.SaveChangesAsync();
        }
    }
}
