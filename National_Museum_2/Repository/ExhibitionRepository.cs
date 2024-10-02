using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IExhibitionRepository
    {
        Task<IEnumerable<Exhibition>> GetAllExhibitionAsync();
        Task<Exhibition> GetExhibitionByAsync(int id);
        Task CreateExhibitionAsync(Exhibition exhibition);
        Task UpdateExhibitionAsync(Exhibition exhibition);
        Task SoftDeleteExhibitionAsync(int id);
    }
    public class ExhibitionRepository : IExhibitionRepository
    {
        public Task CreateExhibitionAsync(Exhibition exhibition)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Exhibition>> GetAllExhibitionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Exhibition> GetExhibitionByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteExhibitionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExhibitionAsync(Exhibition exhibition)
        {
            throw new NotImplementedException();
        }
    }
}
