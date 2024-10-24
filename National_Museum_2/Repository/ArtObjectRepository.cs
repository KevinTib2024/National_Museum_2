using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.DTO.ArtObject;
using System.Reflection;
using National_Museum_2.DTO.Category;

namespace National_Museum_2.Repository
{
    public interface IArtObjectRepository
    {
        Task<IEnumerable<GetArtObjectRequest>> GetAllArtObjectAsync();
        Task<GetArtObjectRequest> GetArtObjectByIdAsync(int id);
        Task CreateArtObjectAsync(CreateArtObjectRequest artObject);
        Task UpdateArtObjectAsync(UpdateArtObjectRequest artObject);
        Task SoftDeleteArtObjectAsync(int id);
    }
    public class ArtObjectRepository : IArtObjectRepository
    {
        private readonly MuseumDbContext _context;

        public ArtObjectRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateArtObjectAsync(CreateArtObjectRequest artObject)
        {
            var _exhibition = await _context.exhibition.FindAsync(artObject.exhibition_Id);
            var _category = await _context.categories.FindAsync(artObject.category_Id);
            var _state = await _context.state.FindAsync(artObject.state_Id);

            if (_exhibition == null)
            {
                throw new Exception("No se encontro exhibición");
            }

            if (_category == null)
            {
                throw new Exception("No se encontro categoria");
            }

            if (_state == null)
            {
                throw new Exception("No se encontro estado");
            }

            if (artObject == null)
                throw new ArgumentNullException(nameof(artObject));

            var _newArtObject = new ArtObject
            {
                exhibition_Id = artObject.exhibition_Id,
                category_Id = artObject.category_Id,
                state_Id = artObject.state_Id,
                name = artObject.name,
                description = artObject.description,
                artist = artObject.artist,
                creationDate = artObject.creationDate,
                origin = artObject.origin,
                cost = artObject.cost,
            };

            // Agregar el objeto al contexto
            _context.artObject.Add(_newArtObject);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetArtObjectRequest>> GetAllArtObjectAsync()
        {
            return await _context.artObject
            .Where(s => !s.IsDeleted)
           .Select(s => new GetArtObjectRequest { artObjectId = s.artObjectId, exhibition_Id = s.exhibition_Id, category_Id = s.category_Id, state_Id = s.state_Id, name = s.name, description = s.description, artist = s.artist, creationDate = s.creationDate, origin = s.origin, cost = s.cost  })
            .ToListAsync();
        }

        public async Task<GetArtObjectRequest> GetArtObjectByIdAsync(int id)
        {
            return await _context.artObject
            .Where(s => s.artObjectId == id && !s.IsDeleted)
            .Select(s => new GetArtObjectRequest { artObjectId = s.artObjectId, exhibition_Id = s.exhibition_Id, category_Id = s.category_Id, state_Id = s.state_Id, name = s.name, description = s.description, artist = s.artist, creationDate = s.creationDate, origin = s.origin, cost = s.cost }).FirstOrDefaultAsync();

        }

        public async Task SoftDeleteArtObjectAsync(int id)
        {
            var artObject = await _context.artObject.FindAsync(id);
            if (artObject != null)
            {
                artObject.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateArtObjectAsync(UpdateArtObjectRequest artObject)
        {
            if (artObject == null)
                throw new ArgumentNullException(nameof(artObject));

            var existingArtObject = await _context.artObject.FindAsync(artObject.artObjectId);
            if (existingArtObject == null)
                throw new ArgumentException($"artObejct with ID {artObject.artObjectId} not found");

            // Actualizar las propiedades del objeto existente
            existingArtObject.description= String.IsNullOrEmpty(artObject.description) ? existingArtObject.description : artObject.description;
            existingArtObject.cost = String.IsNullOrEmpty(artObject.cost)? existingArtObject.cost : artObject.cost;
            existingArtObject.creationDate = String.IsNullOrEmpty(artObject.creationDate)? existingArtObject.creationDate :  artObject.creationDate;
            existingArtObject.artist = String.IsNullOrEmpty(artObject.artist)? existingArtObject.artist : artObject.artist;
            existingArtObject.name = String.IsNullOrEmpty(artObject.name)? existingArtObject.name : artObject.name;
            existingArtObject.origin = String.IsNullOrEmpty(artObject.origin)? existingArtObject.origin : artObject.origin;
            existingArtObject.category_Id = artObject.category_Id?? existingArtObject.category_Id;
            existingArtObject.state_Id = artObject.state_Id ?? existingArtObject.category_Id;
            existingArtObject.exhibition_Id = artObject.exhibition_Id ?? existingArtObject.category_Id;

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }
    }
}
