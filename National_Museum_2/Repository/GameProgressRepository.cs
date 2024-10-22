using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.GameProgress;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IGameProgressRepository
    {
        Task<IEnumerable<GameProgress>> GetAllGameProgressAsync();
        Task<GameProgress> GetGameProgressByIdAsync(int id);
        Task CreateGameProgressAsync(CreateGameProgressRequest gameProgress);
        Task UpdateGameProgressAsync(GameProgress gameProgress);
        Task SoftDeleteGameProgressAsync(int id);
    }
    public class GameProgressRepository : IGameProgressRepository
    {
        private readonly MuseumDbContext _context;

        public GameProgressRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateGameProgressAsync(CreateGameProgressRequest gameProgress)
        {

            if (gameProgress == null)
                throw new ArgumentNullException(nameof(gameProgress));
            var _newgameProgress = new GameProgress
            {
                gameProgress = gameProgress.gameProgress,
                description = gameProgress.description, 
            };

            // Agregar el objeto al contexto
            _context.gameProgresses.Add(_newgameProgress);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GameProgress>> GetAllGameProgressAsync()
        {
            return await _context.gameProgresses
           .Where(s => !s.IsDeleted)
           .ToListAsync();
        }

        public async Task<GameProgress> GetGameProgressByIdAsync(int id)
        {
            return await _context.gameProgresses
            .FirstOrDefaultAsync(s => s.gameProgressId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteGameProgressAsync(int id)
        {
            var gameProgress = await _context.gameProgresses.FindAsync(id);
            if (gameProgress != null)
            {
                gameProgress.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateGameProgressAsync(GameProgress gameProgress)
        {
            if (gameProgress == null)
                throw new ArgumentNullException(nameof(gameProgress));

            var existingGameProgress = await _context.gameProgresses.FindAsync(gameProgress.gameProgressId);
            if (existingGameProgress == null)
                throw new ArgumentException($"gameProgress with ID {gameProgress.gameProgressId} not found");

            // Actualizar las propiedades del objeto existente
            existingGameProgress.gameProgress = gameProgress.gameProgress;
            existingGameProgress.description = gameProgress.description;

            await _context.SaveChangesAsync();
        }
    }
}
