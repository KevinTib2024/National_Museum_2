using National_Museum_2.DTO.GameProgress;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IGameProgressService
    {
        Task<IEnumerable<GameProgress>> GetAllGameProgressAsync();
        Task<GameProgress> GetGameProgressByIdAsync(int id);
        Task CreateGameProgressAsync(CreateGameProgressRequest gameProgress);
        Task UpdateGameProgressAsync(UpdateGameProgressRequest gameProgress);
        Task SoftDeleteGameProgressAsync(int id);
    }
    public class GameProgressService : IGameProgressService
    {
        private readonly IGameProgressRepository _gameProgressRepository;

        public GameProgressService(IGameProgressRepository gameProgressRepository)
        {
            _gameProgressRepository = gameProgressRepository;
        }

        public async Task CreateGameProgressAsync(CreateGameProgressRequest gameProgress)
        {
            await _gameProgressRepository.CreateGameProgressAsync(gameProgress);
        }

        public async Task<IEnumerable<GameProgress>> GetAllGameProgressAsync()
        {
            return await _gameProgressRepository.GetAllGameProgressAsync();
        }

        public async Task<GameProgress> GetGameProgressByIdAsync(int id)
        {
            return await _gameProgressRepository.GetGameProgressByIdAsync(id);
        }

        public async Task SoftDeleteGameProgressAsync(int id)
        {
            await _gameProgressRepository.SoftDeleteGameProgressAsync(id);
        }

        public async Task UpdateGameProgressAsync(UpdateGameProgressRequest gameProgress)
        {
            await _gameProgressRepository.UpdateGameProgressAsync(gameProgress);
        }
    }
}
