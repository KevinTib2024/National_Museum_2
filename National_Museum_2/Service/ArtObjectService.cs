using National_Museum_2.Model;
using National_Museum_2.Respository;

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
        public Task CreateArtObjectAsync(ArtObject artObject)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArtObject>> GetAllArtObjectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArtObject> GetArtObjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteArtObjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateARtObjectAsync(ArtObject artObject)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtObjectAsync(ArtObject artObject)
        {
            throw new NotImplementedException();
        }
    }
}
