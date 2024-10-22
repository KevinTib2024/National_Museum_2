using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Games;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IGamesRepository
    {
        Task<IEnumerable<Games>> GetAllGamesAsync();
        Task<Games> GetGamesByIdAsync(int id);
        Task CreateGamesAsync(CreateGamesRequest games);
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

        public async Task CreateGamesAsync(CreateGamesRequest games)
        {
            var _user_Id = await _context.user.FindAsync(games.user_id);
            var _gameState_Id = await _context.gameStates.FindAsync(games.gameState_Id);
            var _scenary_Id = await _context.scenary.FindAsync(games.scenary_Id);
            var _gameProgrees_Id = await _context.gameProgresses.FindAsync(games.gameProgress_Id);

            if (games == null)
                throw new ArgumentNullException(nameof(games));
            if (_user_Id == null)
            {
                throw new Exception("No se encontro id del usuario");
            }
            if (_gameState_Id == null)
            {
                throw new Exception("No se encontro el estado del juego");
            }
            if (_scenary_Id == null)
            {
                throw new Exception("No se encontro el escenario");
            }
            if (_gameProgrees_Id == null)
            {
                throw new Exception("No se encontro el progreso");
            }
            var _newgames = new Games
            {
               user_Id = games.user_id,
               gameDate = games.gameDate,
               gameState_Id = games.gameState_Id,
               gameTime = games.gameTime,   
               punctuation = games.punctuation, 
               scenary_Id = games.scenary_Id,
               gameProgress_Id = games.gameProgress_Id,
            };

            // Agregar el objeto al contexto
            _context.games.Add(_newgames);

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
            existingGames.user_Id = games.user_Id;
            existingGames.gameDate = games.gameDate;
            existingGames.gameState_Id = games.gameState_Id;
            existingGames.gameTime = games.gameTime;
            existingGames.punctuation = games.punctuation;
            existingGames.scenary_Id = games.scenary_Id;
            existingGames.gameProgress_Id = games.gameProgress_Id;

            await _context.SaveChangesAsync();
        }
    }
}
