using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IExhibitionService
    {
        Task<IEnumerable<Exhibition>> GetAllExhibitionAsync();
        Task<Exhibition> GetExhibitionByIdAsync(int id);
        Task CreateExhibitionAsync(Exhibition exhibition);
        Task UpdateExhibitionAsync(Exhibition exhibition);
        Task SoftDeleteExhibitionAsync(int id);
    }
    public class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionRepository _exhibitionRepository;

        public ExhibitionService(IExhibitionRepository exhibitionRepository)
        {
            _exhibitionRepository = exhibitionRepository;
        }

        public async Task CreateExhibitionAsync(Exhibition exhibition)
        {
            await _exhibitionRepository.CreateExhibitionAsync(exhibition);
        }

        public async Task<IEnumerable<Exhibition>> GetAllExhibitionAsync()
        {
            return await _exhibitionRepository.GetAllExhibitionAsync();
        }

        public async Task<Exhibition> GetExhibitionByIdAsync(int id)
        {
            return await _exhibitionRepository.GetExhibitionByIdAsync(id);
        }

        public async Task SoftDeleteExhibitionAsync(int id)
        {
            await _exhibitionRepository.SoftDeleteExhibitionAsync(id);
        }

        public async Task UpdateExhibitionAsync(Exhibition exhibition)
        {
            await _exhibitionRepository.UpdateExhibitionAsync(exhibition);
        }
    }
}