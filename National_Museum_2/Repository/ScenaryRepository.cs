using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Scenary;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IScenaryRepository
    {
        Task<IEnumerable<Scenary>> GetAllScenaryAsync();
        Task<Scenary> GetScenaryByIdAsync(int id);
        Task CreateScenaryAsync(CreateScenaryRequest scenary);
        Task UpdateScenaryAsync(Scenary scenary);
        Task SoftDeleteScenaryAsync(int id);
    }

    public class ScenaryRepository : IScenaryRepository
    {
        private readonly MuseumDbContext _context;

        public ScenaryRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateScenaryAsync(CreateScenaryRequest scenary)
        {
            if (scenary == null)
                throw new ArgumentNullException(nameof(scenary));
            var _newscenary = new Scenary
            {
                scenaryName = scenary.scenaryName,
                description = scenary.description,
                order   = scenary.order,
                achievementsobtained = scenary.achievementsobtained,
            };

            // Agregar el objeto al contexto
            _context.scenary.Add(_newscenary);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Scenary>> GetAllScenaryAsync()
        {
            return await _context.scenary
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Scenary> GetScenaryByIdAsync(int id)
        {
            return await _context.scenary
            .FirstOrDefaultAsync(s => s.scenaryId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteScenaryAsync(int id)
        {
            var scenary = await _context.scenary.FindAsync(id);
            if (scenary != null)
            {
                scenary.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateScenaryAsync(Scenary scenary)
        {
            if (scenary == null)
                throw new ArgumentNullException(nameof(scenary));

            var existingScenary = await _context.scenary.FindAsync(scenary.scenaryId);
            if (existingScenary == null)
                throw new ArgumentException($"scenary with ID {scenary.scenaryId} not found");

            // Actualizar las propiedades del objeto existente
            existingScenary.scenaryName = scenary.scenaryName;
            existingScenary.description = scenary.description;
            existingScenary.order = scenary.order;
            existingScenary.achievementsobtained = scenary.achievementsobtained;

            await _context.SaveChangesAsync();
        }
    }
}