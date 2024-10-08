using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IScenaryService
    {
        Task<IEnumerable<Scenary>> GetAllScenaryAsync();
        Task<Scenary> GetScenaryByIdAsync(int id);
        Task CreateScenaryAsync(Scenary scenary);
        Task UpdateScenaryAsync(Scenary scenary);
        Task SoftDeleteScenaryAsync(int id);
    }
    public class ScenaryService : IScenaryService
    {
        public Task CreateScenaryAsync(Scenary scenary)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Scenary>> GetAllScenaryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Scenary> GetScenaryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteScenaryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateScenaryAsync(Scenary scenary)
        {
            throw new NotImplementedException();
        }
    }
}
