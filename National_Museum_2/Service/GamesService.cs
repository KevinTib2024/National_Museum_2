using National_Museum_2.DTO.Games;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IGamesService
    {
        Task<IEnumerable<Games>> GetAllGamesAsync();
        Task<Games> GetGamesByIdAsync(int id);
        Task CreateGamesAsync(CreateGamesRequest games);
        Task UpdateGamesAsync(Games games);
        Task SoftDeleteGamesAsync(int id);
    }

    public class GamesService : IGamesService
    {
        private readonly IGamesRepository _gamesRepository;

        public GamesService(IGamesRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }

        public async Task CreateGamesAsync(CreateGamesRequest games)
        {
            await _gamesRepository.CreateGamesAsync(games);
        }

        public async Task<IEnumerable<Games>> GetAllGamesAsync()
        {
            return await _gamesRepository.GetAllGamesAsync();
        }

        public async Task<Games> GetGamesByIdAsync(int id)
        {
            return await _gamesRepository.GetGamesByIdAsync(id);
        }

        public async Task SoftDeleteGamesAsync(int id)
        {
            await _gamesRepository.SoftDeleteGamesAsync(id);
        }

        public async Task UpdateGamesAsync(Games games)
        {
            await _gamesRepository.UpdateGamesAsync(games);
        }
    }
}
