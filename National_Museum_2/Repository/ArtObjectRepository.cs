using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.DTO.ArtObject;

namespace National_Museum_2.Repository
{
    public interface IArtObjectRepository
    {
        Task<IEnumerable<ArtObject>> GetAllArtObjectAsync();
        Task<ArtObject> GetArtObjectByIdAsync(int id);
        Task CreateArtObjectAsync(CreateArtObjectRequest artObject);
        Task UpdateArtObjectAsync(ArtObject artObject);
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

        public async Task<IEnumerable<ArtObject>> GetAllArtObjectAsync()
        {
            return await _context.artObject
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<ArtObject> GetArtObjectByIdAsync(int id)
        {
            return await _context.artObject
            .FirstOrDefaultAsync(s => s.artObjectId == id && !s.IsDeleted);
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
        public async Task UpdateArtObjectAsync(ArtObject artObject)
        {
            if (artObject == null)
                throw new ArgumentNullException(nameof(artObject));

            var existingArtObject = await _context.artObject.FindAsync(artObject.artObjectId);
            if (existingArtObject == null)
                throw new ArgumentException($"artObejct with ID {artObject.artObjectId} not found");

            // Actualizar las propiedades del objeto existente
            existingArtObject.description = artObject.description;
            existingArtObject.cost = artObject.cost;
            existingArtObject.creationDate = artObject.creationDate;
            existingArtObject.artist = artObject.artist;
            existingArtObject.name = artObject.name;
            existingArtObject.origin = artObject.origin;
            existingArtObject.category_Id = artObject.category_Id; 
            existingArtObject.state_Id = artObject.state_Id;
            existingArtObject.exhibition_Id = artObject.exhibition_Id;

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }
    }
}
