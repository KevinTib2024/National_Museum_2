using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllLocationAsync();
        Task<Location> GetLocationByIdAsync(int id);
        Task CreateLocationAsync(Location location);
        Task UpdateLocationAsync(Location  location);
        Task SoftDeleteLocationAsync(int id);
    }
    public class LocationRepository : ILocationRepository
    {
        private readonly MuseumDbContext _context;

        public LocationRepository(MuseumDbContext context)
        {
            _context = context;
        }
        public async Task CreateLocationAsync(Location location)
        {
            if (location == null)
                throw new ArgumentNullException(nameof(location));

            // Agregar el objeto al contexto
            _context.location.Add(location);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Location>> GetAllLocationAsync()
        {
            return await _context.location
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Location> GetLocationByIdAsync(int id)
        {
            return await _context.location
            .FirstOrDefaultAsync(s => s.locationId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteLocationAsync(int id)
        {
            var location = await _context.location.FindAsync(id);
            if (location != null)
            {
                location.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateLocationAsync(Location location)
        {
            if (location == null)
                throw new ArgumentNullException(nameof(location));

            var existingLocation = await _context.location.FindAsync(location.locationId);
            if (existingLocation == null)
                throw new ArgumentException($"location with ID {location.locationId} not found");

            // Actualizar las propiedades del objeto existente
            existingLocation.name = location.name;

            await _context.SaveChangesAsync();
        }
    }
}
