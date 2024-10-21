using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Gender;
using National_Museum_2.Model;

  
namespace National_Museum_2.Repository
{
    public interface IGenderRepository
    {
        Task<IEnumerable<Gender>> GetAllGenderAsync();
        Task<Gender> GetGenderByIdAsync(int id);
        Task CreateGenderAsync(CreateGenderRequest gender);
        Task UpdateGenderAsync(Gender gender);
        Task SoftDeleteGenderAsync(int id);
    }

    public class GenderRepository : IGenderRepository
    {
        private readonly MuseumDbContext _context;

        public GenderRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateGenderAsync(CreateGenderRequest gender)
        {
            if (gender == null)
                throw new ArgumentNullException(nameof(gender));
            var _newGender = new Gender
            {
                gender = gender.gender
            };   

            // Agregar el objeto al contexto
            _context.gender.Add(_newGender);


            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Gender>> GetAllGenderAsync()
        {
            return await _context.gender
                .Where(s => !s.IsDeleted)
                .ToListAsync(); 
        }

        public async Task<Gender> GetGenderByIdAsync(int id)
        {
            return await _context.gender
                .FirstOrDefaultAsync(s => s.genderId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteGenderAsync(int id)
        {
            var gender = await _context.gender.FindAsync(id);
            if (gender != null)
            {
                gender.IsDeleted = true;
                await _context.SaveChangesAsync(); 
            }
        }

        public async Task UpdateGenderAsync(Gender gender)
        {
            if (gender == null)
                throw new ArgumentNullException(nameof(gender));

            var existingGender = await _context.gender.FindAsync(gender.genderId);
            if (existingGender == null)
                throw new ArgumentException($"Gender with ID {gender.genderId} not found");

            // Actualizar las propiedades del objeto existente
            existingGender.gender = gender.gender;  

            await _context.SaveChangesAsync();
        }
    }
}
