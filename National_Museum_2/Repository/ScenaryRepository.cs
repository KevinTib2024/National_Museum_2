using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IScenaryRepository
    {
        Task<IEnumerable<Scenary>> GetAllScenaryAsync();
        Task<Scenary> GetScenaryByIdAsync(int id);
        Task CreateScenaryAsync(Scenary scenary);
        Task UpdateScenaryAsync(Scenary scenary);
        Task SoftScenaryAsync(int id);
    }
    public class ScenaryRepository : IScenaryRepository
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

        public Task SoftScenaryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateScenaryAsync(Scenary scenary)
        {
            throw new NotImplementedException();
        }
    }
}
