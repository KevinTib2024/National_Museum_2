using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IGamesRepository
    {
        Task<IEnumerable<Games>> GetAllGamesAsync();
        Task<Games> GetGamesByIdAsync(int id);
        Task CreateGamesAsync(Games games);
        Task UpdateGamesAsync(Games games);
        Task SoftDeleteGamesAsync(int id);
    }

    public class GamesRepository : IGamesRepository
    {
        private readonly MuseumDbContext _context;

        public GamesRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateGamesAsync(Games games)
        {
            if (games == null)
                throw new ArgumentNullException(nameof(games));

            // Agregar el objeto al contexto
            _context.games.Add(games);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Games>> GetAllGamesAsync()
        {
            return await _context.games
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Games> GetGamesByIdAsync(int id)
        {
            return await _context.games
            .FirstOrDefaultAsync(s => s.gameId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteGamesAsync(int id)
        {
            var games = await _context.games.FindAsync(id);
            if (games != null)
            {
                games.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateGamesAsync(Games games)
        {
            if (games == null)
                throw new ArgumentNullException(nameof(games));

            var existingGames = await _context.games.FindAsync(games.gameId);
            if (existingGames == null)
                throw new ArgumentException($"game with ID {games.gameId} not found");

            // Actualizar las propiedades del objeto existente
            existingGames.userId = games.userId;
            existingGames.gameDate = games.gameDate;
            existingGames.gameStateId = games.gameStateId;
            existingGames.gameTime = games.gameTime;
            existingGames.punctuation = games.punctuation;
            existingGames.scenaryId = games.scenaryId;
            existingGames.gameProgressId = games.gameProgressId;

            await _context.SaveChangesAsync();
        }
    }
}
