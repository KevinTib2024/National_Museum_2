using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface IArtObjectRepository
    {
        Task<IEnumerable<ArtObject>> GetAllArtObjectAsync();
        Task<ArtObject> GetArtObjectByAsync(int id);
        Task CreateArtObjectAsync(ArtObject artobject);
        Task UpdateArtObjectAsync(ArtObject artobject);
        Task SoftDeleteArtObjectAsync(int id);
    }
    public class ArtObjectRepository : IArtObjectRepository
    {
        public Task CreateArtObjectAsync(ArtObject artobject)
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

        public Task UpdateArtObjectAsync(ArtObject artobject)
        {
            throw new NotImplementedException();
        }
    }
}
