using National_Museum_2.Model;
using National_Museum_2.Repository;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IGameStateService
    {
        Task<IEnumerable<GameState>> GetAllGameStateAsync();
        Task<GameState> GetGameStateByIdAsync(int id);
        Task CreateGameStateAsync(GameState gameState);
        Task UpdateGameStateAsync(GameState gameState);
        Task SoftDeleteGameStateAsync(int id);
    }
    public class GameStateService : IGameStateService
    {
        private readonly IGameStateRepository _gameStateRepository;

        public GameStateService(IGameStateRepository gameStateRepository)
        {
            _gameStateRepository = gameStateRepository;
        }

        public async Task CreateGameStateAsync(GameState gameState)
        {
            await _gameStateRepository.CreateGameStateAsync(gameState);
        }

        public async Task<IEnumerable<GameState>> GetAllGameStateAsync()
        {
            return await _gameStateRepository.GetAllGameStateAsync();
        }

        public async Task<GameState> GetGameStateByIdAsync(int id)
        {
            return await _gameStateRepository.GetGameStateByIdAsync(id);
        }

        public async Task SoftDeleteGameStateAsync(int id)
        {
            await _gameStateRepository.SoftDeleteGameStateAsync(id);
        }

        public async Task UpdateGameStateAsync(GameState gameState)
        {
            await _gameStateRepository.UpdateGameStateAsync(gameState);
        }
    }
}
