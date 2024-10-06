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
        private readonly IArtRoomRepository _artRoomRepository;

        public ArtRoomService(IArtRoomRepository artRoomRepository)
        {
            _artRoomRepository = artRoomRepository;
        }
        public async Task CreateArtRoomAsync(ArtRoom artRoom)
        {
            await _artRoomRepository.CreateArtRoomAsync(artRoom);
        }

        public async Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync()
        {
            return await _artRoomRepository.GetAllArtRoomAsync();
        }

        public async Task<ArtRoom> GetArtRoomByIdAsync(int id)
        {
            return await _artRoomRepository.GetArtRoomByIdAsync(id);
        }

        public async Task SoftDeleteArtRoomAsync(int id)
        {
            await _artRoomRepository.SoftDeleteArtRoomAsync(id);
        }

        public async Task UpdateArtRoomAsync(ArtRoom artRoom)
        {
            await _artRoomRepository.UpdateArtRoomAsync(artRoom);
        }
    }
}
