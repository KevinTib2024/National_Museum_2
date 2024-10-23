using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Category;
using National_Museum_2.DTO.UserType;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<GetCategoryRequest>> GetAllCategoryAsync();
        Task<GetCategoryRequest> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CreateCategoryRequest category);
        Task UpdateCategoryAsync(Category category);
        Task SoftDeleteCategoryAsync(int id);
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MuseumDbContext _context;

        public CategoryRepository(MuseumDbContext context)
        {
            _context = context;
        }
        public async Task CreateCategoryAsync(CreateCategoryRequest category)
        {

            if (category == null)
                throw new ArgumentNullException(nameof(category));
            var _newcategory = new Category
            {
                category = category.category,
            };
            // Agregar el objeto al contexto
            _context.categories.Add(_newcategory);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetCategoryRequest>> GetAllCategoryAsync()
        {
            return await _context.categories
           .Where(s => !s.IsDeleted)
           .Select(s => new GetCategoryRequest { category = s.category })
           .ToListAsync();
        }

        public async Task<GetCategoryRequest> GetCategoryByIdAsync(int id)
        {
            return await _context.categories
            .Where(s => s.categoryId == id && !s.IsDeleted)
            .Select(s => new GetCategoryRequest { category = s.category }).FirstOrDefaultAsync();

        }

        public async Task SoftDeleteCategoryAsync(int id)
        {
            var category = await _context.categories.FindAsync(id);
            if (category != null)
            {
                category.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            var existingCategory = await _context.categories.FindAsync(category.categoryId);
            if (existingCategory == null)
                throw new ArgumentException($"category with ID {category.categoryId} not found");

            // Actualizar las propiedades del objeto existente
            existingCategory.category = category.category;

            await _context.SaveChangesAsync();
        }
    }
}
