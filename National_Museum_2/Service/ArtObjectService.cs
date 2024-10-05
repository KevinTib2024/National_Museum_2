using National_Museum_2.Model;
using National_Museum_2.Repository;
using System.Reflection;

namespace National_Museum_2.Service
{
    public interface IArtObjectService
    {
        Task<IEnumerable<ArtObject>> GetAllArtObjectAsync();
        Task<ArtObject> GetArtObjectByIdAsync(int id);
        Task CreateArtObjectAsync(ArtObject artObject);
        Task UpdateArtObjectAsync(ArtObject artObject);
        Task SoftDeleteArtObjectAsync(int id);
    }
    public class ArtObjectService : IArtObjectService
    {
        private readonly IArtObjectRepository _artObjectRepository;

        public ArtObjectService(IArtObjectRepository artObjectRepository)
        {
            _artObjectRepository = artObjectRepository;
        }

        public async Task CreateArtObjectAsync(ArtObject artObject)
        {
            await _artObjectRepository.CreateArtObjectAsync(artObject);
        }

        public async Task<IEnumerable<ArtObject>> GetAllArtObjectAsync()
        {
            return await _artObjectRepository.GetAllArtObjectAsync();
        }

        public async Task<ArtObject> GetArtObjectByIdAsync(int id)
        {
            return await _artObjectRepository.GetArtObjectByIdAsync(id);
        }

        public async Task SoftDeleteArtObjectAsync(int id)
        {
            await _artObjectRepository.SoftDeleteArtObjectAsync(id);
        }

        public async Task UpdateArtObjectAsync(ArtObject artObject)
        {
            await _artObjectRepository.UpdateArtObjectAsync(artObject);
        }
    }
}
