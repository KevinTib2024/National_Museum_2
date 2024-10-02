using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IArtObjectService
    {
        Task<IEnumerable<ArtObject>> GetAllArtObjectAsync();
        Task<ArtObject> GetArtObjectByIdAsync(int id);
        Task CreateArtObjectAsync(ArtObject artObject);
        Task UpdateContactAsync(ArtObject artObject);
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

        public Task UpdateContactAsync(ArtObject artObject)
        {
            throw new NotImplementedException();
        }
    }
}
