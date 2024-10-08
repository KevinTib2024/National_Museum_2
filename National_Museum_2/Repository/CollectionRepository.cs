using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ICollectionRepository
    {
        Task<IEnumerable<Collection>> GetAllCollectionAsync();
        Task<Collection> GetCollectionByIdAsync(int id);
        Task CreateCollectionAsync(Collection collection);
        Task UpdateCollectionAsync(Collection collections);
        Task SoftDeleteCollectionAsync(int id);
    }
    public class CollectionRepository : ICollectionRepository
    {
        private readonly MuseumDbContext _context;

        public CollectionRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateCollectionAsync(Collection collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            // Agregar el objeto al contexto
            _context.collection.Add(collection);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Collection>> GetAllCollectionAsync()
        {
            return await _context.collection
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Collection> GetCollectionByIdAsync(int id)
        {
            return await _context.collection
           .FirstOrDefaultAsync(s => s.collectionId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteCollectionAsync(int id)
        {
            var collection = await _context.collection.FindAsync(id);
            if (collection != null)
            {
                collection.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCollectionAsync(Collection collections)
        {
            if (collections == null)
                throw new ArgumentNullException(nameof(collections));

            var existingCollection = await _context.collection.FindAsync(collections.collectionId);
            if (existingCollection == null)
                throw new ArgumentException($"collection with ID {collections.collectionId} not found");

            // Actualizar las propiedades del objeto existente
            existingCollection.name = collections.name;
            existingCollection.description = collections.description;

            await _context.SaveChangesAsync();
        }
    }
}
