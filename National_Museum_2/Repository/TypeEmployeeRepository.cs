using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ITypeEmployeeRepository
    {
        Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync();
        Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id);
        Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee);
        Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee);
        Task SoftDeleteTypeEmployeeAsync(int id);
    }

    public class TypeEmployeeRepository : ITypeEmployeeRepository
    {
        private readonly MuseumDbContext _context;

        public TypeEmployeeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            if (typeEmployee == null)
                throw new ArgumentNullException(nameof(typeEmployee));

            // Agregar el objeto al contexto
            _context.typeEmployee.Add(typeEmployee);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync()
        {
            return await _context.typeEmployee
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id)
        {
            return await _context.typeEmployee
            .FirstOrDefaultAsync(s => s.typeEmployeeId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteTypeEmployeeAsync(int id)
        {
            var typeEmployee = await _context.typeEmployee.FindAsync(id);
            if (typeEmployee != null)
            {
                typeEmployee.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            if (typeEmployee == null)
                throw new ArgumentNullException(nameof(typeEmployee));

            var existingTypeEmployee = await _context.typeEmployee.FindAsync(typeEmployee.typeEmployeeId);
            if (existingTypeEmployee == null)
                throw new ArgumentException($"typeEmployee with ID {typeEmployee.typeEmployeeId} not found");

            // Actualizar las propiedades del objeto existente
            existingTypeEmployee.typeEmployeeId = typeEmployee.typeEmployeeId;

            await _context.SaveChangesAsync();
        }
    }
}
