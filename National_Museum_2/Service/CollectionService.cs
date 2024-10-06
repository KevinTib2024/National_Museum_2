using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ICollectionService
    {
        Task<IEnumerable<Collection>> GetAllCollectionAsync();
        Task<Collection> GetCollectionByIdAsync(int id);
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

        public async Task CreateCollectionAsync(Collection collection)
        {
            await _collectionRepository.CreateCollectionAsync(collection);
        }

        public async Task<IEnumerable<Collection>> GetAllCollectionAsync()
        {
            return await _collectionRepository.GetAllCollectionAsync();
        }

        public async Task<Collection> GetCollectionByIdAsync(int id)
        {
            return await _collectionRepository.GetCollectionByIdAsync(id);
        }

        public async Task SoftDeleteCollectionAsync(int id)
        {
            await _collectionRepository.SoftDeleteCollectionAsync(id);
        }

        public async Task UpdateCollectionAsync(Collection collection)
        {
            await _collectionRepository.UpdateCollectionAsync(collection);
        }
    }
}
