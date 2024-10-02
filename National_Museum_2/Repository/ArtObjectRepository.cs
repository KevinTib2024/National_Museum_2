using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IArtObjectRepository
    {
        Task<IEnumerable<ArtObject>> GetAllArtObjectAsync();
        Task<ArtObject> GetArtObjectByAsync(int id);
        Task CreateArtobjectAsync(ArtObject artObject);
        Task UpdateArtObjectAsync(ArtObject ArtObejct);
        Task SoftDeleteArtObjectAsync(int id);
    }
    public class ArtObjectRepository : IArtObjectRepository
    {
        public Task CreateArtobjectAsync(ArtObject artObject)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArtObject>> GetAllArtObjectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArtObject> GetArtObjectByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteArtObjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtObjectAsync(ArtObject ArtObejct)
        {
            throw new NotImplementedException();
        }
    }
}
