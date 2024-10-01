using National_Museum_2.Context;
using National_Museum_2.Model;
namespace National_Museum_2.Respository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync();
        Task<Category> GetCategoryByAsync(int id);
        Task CreateCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task SoftDeleteCategoryAsync(int id);
    }
    public class CategoryRepository : ICategoryRepository
    {
        public Task CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}