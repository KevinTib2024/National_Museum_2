using National_Museum_2.Model;
using National_Museum_2.Repository;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IExhibitionService
    {
        Task<IEnumerable<Exhibition>> GetAllExhibitionAsync();
        Task<Exhibition> GetExhibitionByIdAsync(int id);
        Task CreateExhibitionAsync(Exhibition exhibition);
        Task UpdateExhibitionAsync(Exhibition exhibition);
        Task SoftExhibitionDeleteAsync(int id);
        Task SoftDeleteExhibitionAsync(int id);
    }
    public class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionRepository _exhibitionRepository;

        public ExhibitionService(IExhibitionRepository exhibitionRepository)
        {
            _exhibitionRepository = exhibitionRepository;
        }

        public Task CreateExhibitionAsync(Exhibition exhibition)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Exhibition>> GetAllExhibitionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Exhibition> GetExhibitionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteExhibitionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftExhibitionDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExhibitionAsync(Exhibition exhibition)
        {
            throw new NotImplementedException();
        }
    }
}
