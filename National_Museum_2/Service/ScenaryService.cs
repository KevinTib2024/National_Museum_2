using National_Museum_2.DTO.Scenary;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IScenaryService
    {
        Task<IEnumerable<Scenary>> GetAllScenaryAsync();
        Task<Scenary> GetScenaryByIdAsync(int id);
        Task CreateScenaryAsync(CreateScenaryRequest scenary);
        Task UpdateScenaryAsync(Scenary scenary);
        Task SoftDeleteScenaryAsync(int id);
    }
    public class ScenaryService : IScenaryService
    {
        private readonly IScenaryRepository _scenaryRepository;

        public ScenaryService(IScenaryRepository scenaryRepository)
        {
            _scenaryRepository = scenaryRepository;
        }
        public async Task CreateScenaryAsync(CreateScenaryRequest scenary)
        {
            await _scenaryRepository.CreateScenaryAsync(scenary);
        }

        public async Task<IEnumerable<Scenary>> GetAllScenaryAsync()
        {
            return await _scenaryRepository.GetAllScenaryAsync();
        }

        public async Task<Scenary> GetScenaryByIdAsync(int id)
        {
            return await _scenaryRepository.GetScenaryByIdAsync(id);
        }

        public async Task SoftDeleteScenaryAsync(int id)
        {
            await _scenaryRepository.SoftDeleteScenaryAsync(id);
        }

        public async Task UpdateScenaryAsync(Scenary scenary)
        {
            await _scenaryRepository.UpdateScenaryAsync(scenary);
        }
    }
}
