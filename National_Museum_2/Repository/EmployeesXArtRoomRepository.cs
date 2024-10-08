using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IEmployeesXArtRoomRepository
    {
        Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync();
        Task<EmployeesXArtRoom> GetEmployeesXArtRoomByIdAsync(int id);
        Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
        Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
        Task SoftDeleteEmployeesXArtRoomAsync(int id);
    }
    public class EmployeesXArtRoomRepository : IEmployeesXArtRoomRepository
    {
        private readonly MuseumDbContext _context;

        public EmployeesXArtRoomRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
        {
            if (employeesXArtRoom == null)
                throw new ArgumentNullException(nameof(employeesXArtRoom));

            // Agregar el objeto al contexto
            _context.employeesXArtRoom.Add(employeesXArtRoom);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync()
        {
            return await _context.employeesXArtRoom
           .Where(s => !s.IsDeleted)
           .ToListAsync();
        }

        public async Task<EmployeesXArtRoom> GetEmployeesXArtRoomByIdAsync(int id)
        {
            return await _context.employeesXArtRoom
            .FirstOrDefaultAsync(s => s.employeesXArtRoomId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteEmployeesXArtRoomAsync(int id)
        {
            var employeesXArtRoom = await _context.employeesXArtRoom.FindAsync(id);
            if (employeesXArtRoom != null)
            {
                employeesXArtRoom.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
        {
            if (employeesXArtRoom == null)
                throw new ArgumentNullException(nameof(employeesXArtRoom));

            var existingEmployeesXArtRoom = await _context.employeesXArtRoom.FindAsync(employeesXArtRoom.employeesXArtRoomId);
            if (existingEmployeesXArtRoom == null)
                throw new ArgumentException($"employeesXArtRoom with ID {employeesXArtRoom.employeesXArtRoomId} not found");

            // Actualizar las propiedades del objeto existente
            existingEmployeesXArtRoom.employeeId = employeesXArtRoom.employeesXArtRoomId;
            existingEmployeesXArtRoom.artRoomId = employeesXArtRoom.artRoomId;

            await _context.SaveChangesAsync();
        }
    }
}