﻿using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IArtRoomRepository
    {

        Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync();
        Task<ArtRoom> GetArtRoomByAsync(int id);
        Task CreateArtRoomAsync(ArtRoom artRoom);
        Task UpdateArtRoomAsync(ArtRoom artRoom);
        Task SoftDeleteArtRoomAsync(int id);
    }
    public class ArtRoomRepository : IArtRoomRepository
    {
        public Task CreateArtRoomAsync(ArtRoom artRoom)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArtRoom> GetArtRoomByAsync(int id)
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
    }
}