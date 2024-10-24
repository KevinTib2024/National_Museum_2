using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using National_Museum_2.Context;
using National_Museum_2.DTO.Exhibition;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IExhibitionRepository
    {
        Task<IEnumerable<Exhibition>> GetAllExhibitionAsync();
        Task<Exhibition> GetExhibitionByIdAsync(int id);
        Task CreateExhibitionAsync(CreateExhibitionRequest exhibition);
        Task UpdateExhibitionAsync(Exhibition exhibition);
        Task SoftDeleteExhibitionAsync(int id);
    }
    public class ExhibitionRepository : IExhibitionRepository
    {
        private readonly MuseumDbContext _context;

        public ExhibitionRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateExhibitionAsync(CreateExhibitionRequest exhibition)
        {
            var _artRoom = await _context.exhibition.FindAsync(exhibition.artRoom_Id);
            if (exhibition == null)
                throw new ArgumentNullException(nameof(exhibition));

            if (_artRoom == null)
            {
                throw new Exception("No se encontro id de la sala");
            }
            var _newexhibition = new Exhibition
            {
                artRoom_Id = exhibition.artRoom_Id,
                name = exhibition.name,
                description = exhibition.description,
            };

            // Agregar el objeto al contexto
            _context.exhibition.Add(_newexhibition);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Exhibition>> GetAllExhibitionAsync()
        {
            return await _context.exhibition
             .Where(s => !s.IsDeleted)
             .ToListAsync();
        }

        public async Task<Exhibition> GetExhibitionByIdAsync(int id)
        {
            return await _context.exhibition
            .FirstOrDefaultAsync(s => s.exhibitionId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteExhibitionAsync(int id)
        {
            var exhibition = await _context.exhibition.FindAsync(id);
            if (exhibition != null)
            {
                exhibition.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateExhibitionAsync(Exhibition exhibition)
        {
            if (exhibition == null)
                throw new ArgumentNullException(nameof(exhibition));

            var existingExhibition = await _context.exhibition.FindAsync(exhibition.exhibitionId);
            if (existingExhibition == null)
                throw new ArgumentException($"exhibition with ID {exhibition.exhibitionId} not found");

            // Actualizar las propiedades del objeto existente
            existingExhibition.name = exhibition.name;
            existingExhibition.description = exhibition.description;
            existingExhibition.artRoom_Id = exhibition.artRoom_Id;

            await _context.SaveChangesAsync();
        }
    }
}
