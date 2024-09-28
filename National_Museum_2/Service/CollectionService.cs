using National_Museum_2.Model;
using National_Museum_2.Respositoy.National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface ICollectionService
    {
        Task<IEnumerable<Collection>> GetAllCollectionAsync();
        Task<Collection> GetCollectionAsync(int id);
        Task CreateCollectionAsync(Collection collection);
        Task UpdateCollectionAsync(Collection collection);
        Task SoftDeleteCollectionAsync(int id);
    }

    public class CollectionService : ICollectionService
    {
        private readonly ICollectionRepository _collectionRepository;

        public CollectionService(ICollectionRepository collectionRepository)
        {
            _collectionRepository = collectionRepository;
        }

        public Task CreateCollectionAsync(Collection collection)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Collection>> GetAllCollectionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Collection> GetCollectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteCollectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCollectionAsync(Collection collection)
        {
            throw new NotImplementedException();
        }
    }
}
