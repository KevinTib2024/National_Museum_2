using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.DTO.ArtRoom;

namespace National_Museum_2.Repository
{
    public interface IArtRoomRepository
    {

        Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync();
        Task<ArtRoom> GetArtRoomByIdAsync(int id);
        Task CreateArtRoomAsync(CreateArtRoomRequest artRoom);
        Task UpdateArtRoomAsync(ArtRoom artRoom);
        Task SoftDeleteArtRoomAsync(int id);
    }
    public class ArtRoomRepository : IArtRoomRepository
    {
        private readonly MuseumDbContext _context;

        public ArtRoomRepository(MuseumDbContext context)
        {
            _context = context;
        }
        public async Task CreateArtRoomAsync(CreateArtRoomRequest artRoom)
        {
            var _location = await _context.location.FindAsync(artRoom.location_Id);
            var _collection = await _context.collection.FindAsync(artRoom.collection_Id);

            if (_location == null)
            {
                throw new Exception("No se encontro ubicación");
            }

            if (_collection == null)
            {
                throw new Exception("No se encontro colección");
            }

            if (artRoom == null)
                throw new ArgumentNullException(nameof(artRoom));

            var _newArtRoom = new ArtRoom
            {
                location_Id = artRoom.location_Id,
                collection_Id = artRoom.collection_Id,
                name = artRoom.name,
                description = artRoom.description,
                numberExhibitions = artRoom.numberExhibitions,
            };

            // Agregar el objeto al contexto
            _context.artRoom.Add(_newArtRoom);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ArtRoom>> GetAllArtRoomAsync()
        {
            return await _context.artRoom
             .Where(s => !s.IsDeleted)
             .ToListAsync();
        }

        public async Task<ArtRoom> GetArtRoomByIdAsync(int id)
        {
            return await _context.artRoom
            .FirstOrDefaultAsync(s => s.artRoomId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteArtRoomAsync(int id)
        {
            var artRoom = await _context.artRoom.FindAsync(id);
            if (artRoom != null)
            {
                artRoom.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateArtRoomAsync(ArtRoom artRoom)
        {
            if (artRoom == null)
                throw new ArgumentNullException(nameof(artRoom));

            var existingArtRoom = await _context.artRoom.FindAsync(artRoom.artRoomId);
            if (existingArtRoom == null)
                throw new ArgumentException($"artRoom with ID {artRoom.artRoomId} not found");

            // Actualizar las propiedades del objeto existente
            existingArtRoom.name = artRoom.name;
            existingArtRoom.description = artRoom.description;
            existingArtRoom.location_Id = artRoom.location_Id;
            existingArtRoom.numberExhibitions = artRoom.numberExhibitions;
            existingArtRoom.collection_Id = artRoom.collection_Id;
            existingArtRoom.employeesXArtRoom = artRoom.employeesXArtRoom;

            await _context.SaveChangesAsync();
        }
    }
}
