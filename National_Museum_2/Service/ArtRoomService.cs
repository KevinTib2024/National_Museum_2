using National_Museum_2.Model;
using National_Museum_2.Repository;
namespace National_Museum_2.Service
{
    public interface IArtRoomService
    {
        Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync();
        Task<ArtRoom> GetArtRoomByIdAsync(int id);
        Task CreateArtRoomAsync(ArtRoom artRoom);
        Task UpdateArtRoomAsync(ArtRoom artRoom);
        Task SoftDeleteArtRoomAsync(int id);
    }
    public class ArtRoomService : IArtRoomService
    {
        public Task CreateArtRoomAsync(ArtRoom artRoom)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArtRoom> GetArtRoomByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteArtRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtRoomAsync(ArtRoom artRoom)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactAsync(ArtRoom artRoom)
        {
            throw new NotImplementedException();
        }
    }
}
