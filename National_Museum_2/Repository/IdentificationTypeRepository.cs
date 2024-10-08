using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IIdentificationTypeRepository
    {
        Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync();
        Task<IdentificationType> GetIdentificationTypeByIdAsync(int id);
        Task CreateIdentificationTypeAsync(IdentificationType identificationType);
        Task UpdateIdentificationTypeAsync(IdentificationType identificationType);
        Task SoftDeleteIdentificationTypeAsync(int id);
    }

    public class IdentificationTypeRepository : IIdentificationTypeRepository
    {
        private readonly MuseumDbContext _context;

        public IdentificationTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateIdentificationTypeAsync(IdentificationType identificationType)
        {
            if (identificationType == null)
                throw new ArgumentNullException(nameof(identificationType));

            // Agregar el objeto al contexto
            _context.identificationType.Add(identificationType);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync()
        {
            return await _context.identificationType
           .Where(s => !s.IsDeleted)
           .ToListAsync();
        }

        public async Task<IdentificationType> GetIdentificationTypeByIdAsync(int id)
        {
            return await _context.identificationType
            .FirstOrDefaultAsync(s => s.identificationTypeId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteIdentificationTypeAsync(int id)
        {
            var identificationType = await _context.identificationType.FindAsync(id);
            if (identificationType != null)
            {
                identificationType.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateIdentificationTypeAsync(IdentificationType identificationType)
        {
            if (identificationType == null)
                throw new ArgumentNullException(nameof(identificationType));

            var existingIdentificationType = await _context.identificationType.FindAsync(identificationType.identificationTypeId);
            if (existingIdentificationType == null)
                throw new ArgumentException($"identificationType with ID {identificationType.identificationTypeId} not found");

            // Actualizar las propiedades del objeto existente
            existingIdentificationType.Identification_Type = identificationType.Identification_Type;

            await _context.SaveChangesAsync();
        }
    }
}
