using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ICollectionRepository
    {
        Task<IEnumerable<Collection>> GetAllCollectionAsync();
        Task<Collection> GetCollectionByAsync(int id);
        Task CreateCollectionAsync(Collection collection);
        Task UpdateCollectionAsync(Collection collections);
        Task SoftDeleteCollectionAsync(int id);
    }
    public class CollectionRepository : ICollectionRepository
    {
        private readonly MuseumDbContext _context;

        public CollectionRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateCollectionAsync(Collection collection)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Collection>> GetAllCollectionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Collection> GetCollectionByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteCollectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCollectionAsync(Collection collections)
        {
            throw new NotImplementedException();
        }
    }
}
