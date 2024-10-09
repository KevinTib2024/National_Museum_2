using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IGameStateRepository
    {
        Task<IEnumerable<GameState>> GetAllGameStateAsync();
        Task<GameState> GetGameStateByIdAsync(int id);
        Task CreateGameStateAsync(GameState gameState);
        Task UpdateGameStateAsync(GameState gameState);
        Task SoftDeleteGameStateAsync(int id);
    }
    public class GameStateRepository : IGameStateRepository
    {
        private readonly MuseumDbContext _context;

        public GameStateRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateGameStateAsync(GameState gameState)
        {
            if (gameState == null)
                throw new ArgumentNullException(nameof(gameState));

            // Agregar el objeto al contexto
            _context.gameStates.Add(gameState);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GameState>> GetAllGameStateAsync()
        {
            return await _context.gameStates
           .Where(s => !s.IsDeleted)
           .ToListAsync();
        }

        public async Task<GameState> GetGameStateByIdAsync(int id)
        {
            return await _context.gameStates
            .FirstOrDefaultAsync(s => s.gameStateId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteGameStateAsync(int id)
        {
            var gameState = await _context.gameStates.FindAsync(id);
            if (gameState != null)
            {
                gameState.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateGameStateAsync(GameState gameState)
        {
            if (gameState == null)
                throw new ArgumentNullException(nameof(gameState));

            var existingGameState = await _context.gameStates.FindAsync(gameState.gameStateId);
            if (existingGameState == null)
                throw new ArgumentException($"gameState with ID {gameState.gameStateId} not found");

            // Actualizar las propiedades del objeto existente
            existingGameState.gameState = gameState.gameState;

            await _context.SaveChangesAsync();
        }
    }
}
